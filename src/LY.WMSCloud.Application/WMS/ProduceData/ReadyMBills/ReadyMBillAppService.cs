using Abp.Configuration;
using AutoMapper;
using LY.WMSCloud.Base;
using LY.WMSCloud.CommonService;
using LY.WMSCloud.Entities.BaseData;
using LY.WMSCloud.Entities.ProduceData;
using LY.WMSCloud.Entities.StorageData;
using LY.WMSCloud.WMS.ProduceData.ReadyMBills.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LY.WMSCloud.WMS.ProduceData.ReadyMBills
{
    public class ReadyMBillAppService : ServiceBase<ReadyMBill, ReadyMBillDto, string>, IReadyMBillAppService
    {
        public ReadyMBillAppService(IWMSRepositories<ReadyMBill, string> repository) : base(repository)
        {
        }

        readonly IWMSRepositories<ReadyMBill, string> _repositoryReadyMBill;
        readonly IWMSRepositories<ReadyMBillDetailed, string> _repositoryReadyMBilld;
        readonly IWMSRepositories<ReelMoveMethod, string> _repositoryRMM;
        readonly IWMSRepositories<WorkBill, string> _repositoryWorkBill;
        readonly IWMSRepositories<ReadyMBillWorkBillMap, string> _readyMBillWorkBillMap;
        readonly IWMSRepositories<Reel, string> _repositoryReel;
        readonly LightService LightService;
        readonly IWMSRepositories<ReelMoveLog, string> _reelMoveLog;
        readonly IWMSRepositories<MPN, string> _repositoryMPN;
        readonly IWMSRepositories<Line, string> _repositoryLine;
        readonly IWMSRepositories<ReadySlot, string> _repositoryReadySlot;
        readonly IWMSRepositories<UPH, string> _repositoryUPH;
        readonly IWMSRepositories<Slot, string> _repositorySlot;
        readonly IWMSRepositories<StorageLocation, string> _repositorySL;
        readonly IWMSRepositories<Setting, long> _repositoryT;
        readonly IWMSRepositories<ReelSendTemp, string> _repositoryRST;
        readonly IWMSRepositories<ReelShortTemp, string> _repositoryRSHT;


        public ReadyMBillAppService(
            IWMSRepositories<ReadyMBill, string> repositoryReadyMBill,
            IWMSRepositories<ReadyMBillDetailed, string> repositoryReadyMBilld,
            IWMSRepositories<Reel, string> repositoryReel,
            IWMSRepositories<ReelMoveMethod, string> repositoryRMM,
            IWMSRepositories<WorkBill, string> repositoryWorkBill,
            IWMSRepositories<ReelSendTemp, string> repositoryRST,
            IWMSRepositories<Slot, string> repositorySlot,
            IWMSRepositories<UPH, string> repositoryUPH,
            IWMSRepositories<ReelShortTemp, string> repositoryRSHT,
            IWMSRepositories<StorageLocation, string> repositorySL,
            IWMSRepositories<MPN, string> repositoryMPN,
            IWMSRepositories<Line, string> repositoryLine,
            IWMSRepositories<ReelMoveLog, string> reelMoveLog,
             LightService lightService,
            IWMSRepositories<ReadySlot, string> repositoryReadySlot,
            IWMSRepositories<Setting, long> repositoryT,
            IWMSRepositories<ReadyMBillWorkBillMap, string> readyMBillWorkBillMap) : base(repositoryReadyMBill)
        {
            this._repositoryReadyMBill = repositoryReadyMBill;
            _repositoryWorkBill = repositoryWorkBill;
            _readyMBillWorkBillMap = readyMBillWorkBillMap;
            _repositoryRMM = repositoryRMM;
            _repositoryReadyMBilld = repositoryReadyMBilld;
            _repositoryReel = repositoryReel;
            _repositoryRST = repositoryRST;
            _repositoryRSHT = repositoryRSHT;
            _repositorySL = repositorySL;
            _repositoryLine = repositoryLine;
            _repositoryMPN = repositoryMPN;
            _repositorySlot = repositorySlot;
            _repositoryUPH = repositoryUPH;
            _repositoryT = repositoryT;
            _reelMoveLog = reelMoveLog;
            LightService = lightService;
            _repositoryReadySlot = repositoryReadySlot;
        }

        public override Task<ReadyMBillDto> Update(ReadyMBillDto input)
        {
            // 删除工单明细
            foreach (var item in _readyMBillWorkBillMap.GetAll().Where(r => r.ReadyMBillId == input.Id).ToList())
            {
                _readyMBillWorkBillMap.Delete(item.Id);
            }

            // 删除备料单明细
            var rms = _repositoryReadyMBilld.GetAllList(rm => rm.ReadyMBillId == input.Id);
            foreach (var item in rms)
            {
                _repositoryReadyMBilld.Delete(item.Id);
            }

            CurrentUnitOfWork.SaveChanges();

            return base.Update(input);
        }

        public async Task<ICollection<ReadyMBillDetailedDto>> GetDetailedById(string id)
        {
            var res = await _repositoryReadyMBilld.GetAll().Where(r => r.ReadyMBillId == id).ToListAsync();

            return ObjectMapper.Map<List<ReadyMBillDetailedDto>>(res);
        }

        public async Task<ICollection<ReadyMBillWorkBillMapDto>> GetWorkBillById(string id)
        {
            var res = await _readyMBillWorkBillMap.GetAll().Where(r => r.ReadyMBillId == id).ToListAsync();

            return ObjectMapper.Map<List<ReadyMBillWorkBillMapDto>>(res);
        }

        public async Task<ICollection<ReadyMBillDto>> GetFollowReadyMBillKeyName(string keyName)
        {
            var res = await _repositoryReadyMBill.GetAll().Where(r => r.Id.Contains(keyName)).Take(10).ToListAsync(); ;

            return ObjectMapper.Map<List<ReadyMBillDto>>(res);
        }


        public async Task<bool> BatchInsOrUpdate(ICollection<RBBatchReadyMBillDto> input)
        {
            try
            {
                // 汇总
                var grouping = input.GroupBy(i => new { i.ProductId, i.Id, i.WorkBillId, i.WorkQty, i.LineId, i.IsActive, i.ForCustomerMStorageId, i.ForSelfMStorageId, i.ReelMoveMethodId });
                foreach (var item in grouping)
                {
                    // 检查线别
                    var line = await _repositoryLine.FirstOrDefaultAsync(item.Key.LineId);
                    if (line == null)
                    {
                        await _repositoryLine.InsertAsync(new Line()
                        {
                            Id = item.Key.LineId,
                            Name = item.Key.LineId,
                            IsActive = true,
                            ForCustomerMStorageId = item.Key.ForCustomerMStorageId,
                            ForSelfMStorageId = item.Key.ForSelfMStorageId,
                            Remark = "系统自动维护,相关仓库可自己改动"
                        });
                        await CurrentUnitOfWork.SaveChangesAsync();
                    }
                    // 检查工单
                    var workBill = await _repositoryWorkBill.FirstOrDefaultAsync(item.Key.WorkBillId);
                    if (workBill == null)
                    {
                        await _repositoryWorkBill.InsertAsync(new WorkBill()
                        {
                            Id = item.Key.WorkBillId,
                            WorkBillStatus = WorkBillStatus.New,
                            LineId = item.Key.LineId,
                            ProductId = item.Key.ProductId,
                            Qty = item.Key.WorkQty,
                            IsActive = true,
                            Remark = "自动同步产生工单"
                        });
                    }
                    else
                    {
                        workBill.LineId = item.Key.LineId;
                        workBill.ProductId = item.Key.ProductId;
                        workBill.Qty = item.Key.WorkQty;
                    }
                    await CurrentUnitOfWork.SaveChangesAsync();
                    // 检查备料单
                    var readyMBill = await _repositoryReadyMBill.FirstOrDefaultAsync(item.Key.Id);
                    if (workBill == null)
                    {
                        await _repositoryReadyMBill.InsertAsync(new ReadyMBill()
                        {
                            Id = item.Key.Id,
                            IsActive = true,
                            MakeDetailsType = MakeDetailsType.Slot,
                            ReadyMType = ReadyMType.JIT,
                            ReelMoveMethodId = item.Key.ReelMoveMethodId,
                            WorkBills = new List<ReadyMBillWorkBillMap>()
                        {
                             new ReadyMBillWorkBillMap()
                             {
                                  Qty=item.Key.WorkQty,
                                  WorkBillId=item.Key.WorkBillId,
                                  ReadyMBillId=item.Key.Id
                             }
                        },
                            Remark = "自动同步备料单",
                            Productstr = item.Key.ProductId,
                            Linestr = item.Key.LineId,
                            WorkBilQtys = item.Key.Id + ':' + item.Key.WorkQty
                        });
                    }
                    else
                    {
                        var wrMap = await _readyMBillWorkBillMap.GetAll().Where(r => r.WorkBillId == item.Key.WorkBillId && r.ReadyMBillId == item.Key.Id).FirstOrDefaultAsync();

                        if (wrMap != null)
                        {
                            wrMap.Qty = item.Key.WorkQty;
                        }

                        readyMBill.Productstr = item.Key.ProductId;
                        readyMBill.Linestr = item.Key.LineId;
                        readyMBill.WorkBilQtys = item.Key.Id + ':' + item.Key.WorkQty;
                    }
                    await CurrentUnitOfWork.SaveChangesAsync();
                    // 检查备料单详细
                    foreach (var partNo in item)
                    {
                        // 检查是否存在
                        var readyMBillDetailed = await _repositoryReadyMBilld.FirstOrDefaultAsync(r => r.ReadyMBillId == item.Key.Id && r.PartNoId == partNo.PartNoId);
                        if (readyMBillDetailed == null)
                        {
                            await _repositoryReadyMBilld.InsertAsync(new ReadyMBillDetailed()
                            {
                                ReadyMBillId = partNo.Id,
                                PartNoId = partNo.PartNoId,
                                Qty = partNo.PartNoQty,
                                IsActive = true,
                                ReelMoveMethodId = partNo.ReelMoveMethodId,
                            });
                        }
                        else
                        {
                            readyMBillDetailed.Qty = partNo.PartNoQty;
                        }
                    }
                    await CurrentUnitOfWork.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception es)
            {
                throw new LYException(es);
            }
        }

        public async Task<ReadyMResultDto> ReadyM(ReadyMDto readyM)
        {
            if (readyM.ReadyMBills.GroupBy(s => new { s.Linestr }).Count() > 1)
            {
                throw new LYException("合并工单必须为相同线别");
            }

            // 判断本次备料单是否全部有备料记录
            var rms = await _repositoryReadyMBill.GetAll().Where(r => readyM.ReadyMBills.Select(rm => rm.Id).Contains(r.Id) && r.ReReadyMBillId != null).Select(r => r.ReReadyMBillId).Distinct().ToListAsync();

            // 有过备料记录的
            if (rms.Count > 1)
            {
                // 本次备料勾选混乱
                throw new LYException("若本次备料包含多个备料单,那么本次备料必须和历史备料勾选一致");
            }
            else if (rms.Count == 1)
            {
                if (rms[0] != readyM.ReReadyMBill)
                {
                    throw new LYException("本次备料记账备料单[" + readyM.ReReadyMBill + "]和历史记账备料单[" + rms[0] + "]不一致");
                }
            }

            // 清除现有灯状态
            var la = await _repositorySL.GetAllListAsync(s => s.BrightState != BrightState.Off);
            foreach (var sl in la)
            {
                sl.BrightState = BrightState.Off;
                // await _repositorySL.UpdateAsync(sl);
            }

            // 清除两张临时表
            await _repositoryRST.DeleteAsync(r => true);

            await _repositoryRSHT.DeleteAsync(r => true);

            await CurrentUnitOfWork.SaveChangesAsync();

            ReadyMResultDto readyMResultDto = new ReadyMResultDto() { ReReadyMBillId = readyM.ReReadyMBill };
            List<ReelSendTemp> reelSendTempDtos = new List<ReelSendTemp>();
            List<ReelShortTemp> reelShortTemps = new List<ReelShortTemp>();

            // 记账备料单
            // var ReReadyMBill = _repositoryReadyMBill.Get(readyM.ReReadyMBill);
            var ReReadyMBill = await _repositoryReadyMBill.GetAll().Where(r => r.Id == readyM.ReReadyMBill).Include(r => r.WorkBills).ThenInclude(w => w.WorkBill).FirstOrDefaultAsync();

            // 调拨策略
            var ReelMoveMethod = await _repositoryRMM.GetAll().Where(rmm => rmm.Id == ReReadyMBill.ReelMoveMethodId).Include(s => s.OutStorages).FirstOrDefaultAsync();

            // 查询备损数量
            var readyLossQty = int.Parse((await _repositoryT.FirstOrDefaultAsync(c => c.TenantId == AbpSession.TenantId && c.Name == "readyLossQty")).Value);

            // 查询提前预警天数
            // var overdueDay = int.Parse((await _repositoryT.FirstOrDefaultAsync(c => c.TenantId == AbpSession.TenantId && c.Name == "overdueDay")).Value);

            // 查询强制先进先出天数
            var mustFifoDay = int.Parse((await _repositoryT.FirstOrDefaultAsync(c => c.TenantId == AbpSession.TenantId && c.Name == "mustFifoDay")).Value);

            // 添加备料绑定关系

            foreach (var readyItemDto in readyM.ReadyMBills)
            {
                var readyItem = await _repositoryReadyMBill.FirstOrDefaultAsync(readyItemDto.Id);

                if (readyItem.ReReadyMBillId != null && readyItem.ReReadyMBillId != ReReadyMBill.Id)
                {
                    throw new LYException(string.Format("所选备料单[{0}]已与[{1}]合并备料,不能再和[{2}]合并备料", readyItem.Id, readyItem.ReReadyMBillId, ReReadyMBill.Id));
                }

                readyItem.ReReadyMBillId = ReReadyMBill.Id;
                await _repositoryReadyMBill.UpdateAsync(readyItem);
            }

            // 查询当前工单的物料需求详情
            var readyMBs = await _repositoryReadyMBilld.GetAll().Where(r => readyM.ReadyMBills.Select(rm => rm.Id).Contains(r.ReadyMBillId))
                .ToListAsync();

            var groupReadyMBs = readyMBs.GroupBy(s => s.PartNoId).Select(s => new ReadyMBillDetailedDto()
            {
                Id = s.FirstOrDefault(sm => sm.ReadyMBillId == ReReadyMBill.Id) != null ?
                     s.FirstOrDefault(sm => sm.ReadyMBillId == ReReadyMBill.Id).Id :
                     s.OrderBy(g => g.Id).FirstOrDefault().Id,
                PartNoId = s.Key,
                DemandQty = s.Sum(rm => rm.Qty),
                SendQty = s.Sum(rm => rm.SendQty),
                ReturnQty = s.Sum(rm => rm.ReturnQty)
            }).ToList();

            // 获取首套料工单
            var firstWoBill = ReReadyMBill.WorkBills.FirstOrDefault().WorkBill;

            // 获取所有工单套数
            var woQty = readyM.ReadyMBills.Select(r => r.WorkBilQtys.Split('|').Select(q => int.Parse(q.Split(':')[1])).Sum()).Sum();

            // 查询UPH值
            var uph = await _repositoryUPH.FirstOrDefaultAsync(r => r.ProductId == firstWoBill.ProductId && r.LineId == firstWoBill.LineId);

            if (uph == null)
            {
                throw new LYException(string.Format("机种[{0}];线别{1}未维护UPH信息", firstWoBill.ProductId, firstWoBill.LineId));
            }

            // 查询料站表
            var slots = await _repositorySlot.GetAll().Where(s => s.ProductId == firstWoBill.ProductId && s.LineId == firstWoBill.LineId && s.IsActive)
                .OrderBy(s => (int)s.BoardSide * -1)
                .ThenBy(s => s.Index)
                .ToListAsync();

            // 按料需求详情生成发料料站表
            foreach (var readym in groupReadyMBs)
            {
                // 查询该料号的料站表

                var onePNSlot = slots.Where(s => s.PartNoId == readym.PartNoId);

                foreach (var slot in onePNSlot)
                {
                    var sendSlot = await _repositoryReadySlot.GetAll().FirstOrDefaultAsync(rs => rs.SlotId == slot.Id && rs.ReReadyMBillId == ReReadyMBill.Id);
                    if (sendSlot == null)
                    {
                        var sendSlotN = Mapper.Map<ReadySlot>(slot);
                        if (sendSlotN != null)
                        {
                            sendSlotN.Id = null;
                            sendSlotN.SlotId = slot.Id;
                            sendSlotN.ReReadyMBillId = ReReadyMBill.Id;
                            sendSlotN.SendPartNoId = readym.PartNoId;
                            sendSlotN.DemandQty = readym.DemandQty;
                            sendSlotN.ReadyMBillDetailedId = readym.Id;
                            await _repositoryReadySlot.InsertAsync(sendSlotN);
                        }
                    }
                }
            }

            await CurrentUnitOfWork.SaveChangesAsync();

            // 查询沿用工单的余料详情,且剩余数大于0的发料详细
            var followReadyBills = _repositoryReadyMBill.GetAll().Where(r => r.ReReadyMBillId == readyM.FollowReadyMBill.ReReadyMBillId);

            var surplusReels = _repositoryReadyMBilld.GetAll().Where(re => followReadyBills.Select(r => r.Id).Contains(re.ReadyMBillId))
                .GroupBy(r => r.PartNoId).Select(r => new
                {
                    ReadyMBillDetailedId = r.FirstOrDefault().Id,
                    PartNoId = r.Key,
                    Qty = r.Sum(reel => reel.SendQty) - r.Sum(reel => reel.Qty) - r.Sum(reel => reel.ReturnQty)
                })
                .Where(r => r.Qty > 0);

            // 按料站表进行发料            
            foreach (var slot in slots)
            {
                // 计算该站位用量 站位用量×所有备料单下面所有工单套数
                var slotDemandQty = (int)Math.Ceiling((Double)slot.Qty / uph.Pin * woQty);

                // 查询该站位已发料数量
                var slotSendQty = await _repositoryReadySlot.GetAll().Where(m => m.ReReadyMBillId == ReReadyMBill.Id && m.SlotId == slot.Id).SumAsync(m => m.SendQty);

                // 该站位还需发料数量
                var slotQty = slotDemandQty - slotSendQty + readyLossQty;

                if (slotQty > 0) // 该站位还需发料
                {
                    // 查询替代料关系
                    var readySlots = await _repositoryReadySlot.GetAll().Where(r => r.SlotId == slot.Id &&
                     r.ReReadyMBillId == ReReadyMBill.Id && r.DemandQty > 0).OrderBy(r => r.DemandQty).ToListAsync();


                    while (slotQty > 0 && readySlots.Count > 0)  // 当该站位未挑够料 且 替代料关系没有用完 一直挑料
                    {
                        var readySlot = readySlots.FirstOrDefault();

                        readySlots.Remove(readySlot);

                        if (readySlot == null)
                        {
                            break;
                        }


                        // 查询该发料单发料情况
                        var readySlotDDto = groupReadyMBs.FirstOrDefault(r => r.PartNoId == readySlot.SendPartNoId);

                        //if (readySlotDDto == null)
                        //{
                        //    Logger.Info("+++" + Newtonsoft.Json.JsonConvert.SerializeObject(readySlot.ReadyMBillDetailedId));
                        //}

                        var readySlotD = await _repositoryReadyMBilld.FirstOrDefaultAsync(readySlotDDto.Id);

                        readySlotD.DemandQty = readySlotDDto.DemandQty;
                        // readySlotD.SendQty = readySlotDDto.SendQty;
                        // readySlotD.ReturnQty = readySlotDDto.ReturnQty;

                        // 算出可发料数量 需求+退料-已发+备损
                        var demandSendQty = (readySlotDDto.DemandQty + readySlotDDto.ReturnQty - readySlotDDto.SendQty);

                        // 获取当前发料单本物料剩余可发数量
                        var nowDemandSendQty = demandSendQty - reelSendTempDtos.Where(rst => rst.PartNoId == readySlotDDto.PartNoId).Sum(rst => rst.Qty);

                        // 如果需求没有用完 且站位没有发够 且有沿用物料
                        if (readyM.FollowReadyMBill != null && nowDemandSendQty > 0 && slotQty > 0 && surplusReels.Count() > 0)
                        {
                            // 先进行工单沿用,工单沿用全部沿用过来
                            var surplusReel = await surplusReels.FirstOrDefaultAsync(r => r.PartNoId == readySlot.SendPartNoId);

                            if (surplusReel != null)
                            {
                                // 模拟添加发料临时表,且标记为已发
                                reelSendTempDtos.Add(new ReelSendTemp()
                                {
                                    IsActive = true,
                                    PartNoId = readySlot.SendPartNoId,
                                    DemandQty = readySlot.DemandQty,
                                    IsSend = true,
                                    Qty = surplusReel.Qty,
                                    SendQty = surplusReel.Qty,
                                    ReelMoveMethodId = ReReadyMBill.ReelMoveMethodId,
                                    ReReadyMBillId = ReReadyMBill.Id,
                                    ReadyMBillDetailedId = readySlot.ReadyMBillDetailedId,
                                    SlotId = slot.Id
                                });

                                // 已发数量
                                readySlotD.SendQty += surplusReel.Qty;
                                // 沿用数量
                                readySlotD.FollowQty += surplusReel.Qty;

                                // 更新此单的退料数量
                                var readyMBold = _repositoryReadyMBilld.Get(surplusReel.ReadyMBillDetailedId);
                                readyMBold.ReturnQty += surplusReel.Qty;

                                // 重新计算当前需求数量
                                nowDemandSendQty = demandSendQty - reelSendTempDtos.Where(rst => rst.PartNoId == readySlotDDto.PartNoId).Sum(rst => rst.Qty);

                                // 更新站位数量
                                slotQty -= surplusReel.Qty;

                                // 添加沿用的发料日志
                                await _reelMoveLog.InsertAsync(new ReelMoveLog()
                                {
                                    PartNoId = surplusReel.PartNoId,
                                    Qty = surplusReel.Qty,
                                    ReadyMBillId = ReReadyMBill.Id,
                                    ReadyMBillDetailedId = readySlot.ReadyMBillDetailedId,
                                    ReelMoveMethodId = ReReadyMBill.ReelMoveMethodId,
                                    SlotId = slot.Id
                                });
                            }
                        }

                        // 如果需求没有用完 且站位没有发够 接着从库存挑料
                        if (nowDemandSendQty > 0 && slotQty > 0)
                        {
                            // 查询MPN信息                           
                            var mpn = await _repositoryMPN.FirstOrDefaultAsync(readySlot.SendPartNoId);

                            // 查询库存中该料号所有物料 在库存中挑料,分为两部分.一部分强制先进先出。一部分按数量挑选
                            var reels = _repositoryReel.GetAll().Where(r =>
                              r.StorageLocationId.Length > 0            // 有库位
                              && r.IsActive     // 有效
                              && r.PartNoId == readySlot.SendPartNoId   // 料号正确
                              && ReelMoveMethod.OutStorages.Select(s => s.StorageId).Contains(r.StorageId)  // 仓库正确  
                              ).ToList()
                              .Where(r => r.MakeDate.AddDays(mpn.ShelfLife + r.ExtendShelfLife) > DateTime.Now && reelSendTempDtos.FirstOrDefault(s => s.Id == r.Id) == null) // 未过期 且未被挑料
                              .ToList(); // 按d/c 进行先进先出排序

                            // && r.MakeDate.AddDays(mpn.ShelfLife + r.ExtendShelfLife - mustFifoDay) > DateTime.Now  // 必须先进先出



                            // 死循环挑料,库存料盘还有。且没挑够，且站位未发够
                            while (reels.Count > 0 && nowDemandSendQty > 0 && slotQty > 0)
                            {
                                // 先挑选强制发料物料
                                var reel = reels.Where(r => r.MakeDate.AddDays(mpn.ShelfLife + r.ExtendShelfLife - mustFifoDay) > DateTime.Now).OrderBy(r => r.MakeDate).FirstOrDefault();

                                if (reel == null) // 没有强制先进先出
                                {
                                    // 获取库存最大料盘数量
                                    var maxQtyReel = reels.OrderBy(r => r.Qty).FirstOrDefault().Qty;

                                    if (nowDemandSendQty > maxQtyReel)
                                    {
                                        // 当需求数大于库存最大料盘数量,按FIFO取同数量中物料
                                        reel = reels.Where(r => r.Qty == maxQtyReel).OrderBy(r => r.MakeDate).FirstOrDefault();
                                    }
                                    else
                                    {
                                        // 当需求数小于库存最大料盘数量
                                        //  1、先查询库存数量大于需求数且差距最小物料
                                        reel = reels.Where(r => r.Qty > nowDemandSendQty).OrderBy(r => r.Qty).FirstOrDefault();

                                        if (reel == null)
                                        {
                                            // 2、如果没有数量大于需求数物料，直接从最大包装开始拿料
                                            reel = reels.OrderByDescending(r => r.Qty).FirstOrDefault();
                                        }
                                    }
                                }

                                // 模拟添加发料临时表,且标记为已发
                                reelSendTempDtos.Add(new ReelSendTemp()
                                {
                                    Id = reel.Id,
                                    IsActive = true,
                                    PartNoId = readySlotD.PartNoId,
                                    DemandQty = readySlotD.DemandQty,
                                    DemandSendQty = demandSendQty,
                                    IsSend = false,
                                    Qty = reel.Qty,
                                    SendQty = reel.Qty,
                                    StorageLocationId = reel.StorageLocationId,
                                    ReelMoveMethodId = ReReadyMBill.ReelMoveMethodId,
                                    ReReadyMBillId = ReReadyMBill.Id,
                                    ReadyMBillDetailedId = readySlotD.Id,
                                    SlotId = slot.Id
                                });

                                // 标记亮灯,真正的亮灯操作。移到专门的亮灯客户端
                                var sl = _repositorySL.Get(reel.StorageLocationId);
                                sl.BrightState = BrightState.On;
                                await _repositorySL.UpdateAsync(sl);

                                // 已发数量
                                // readySlotD.SendQty += reel.Qty;
                                reel.SlotId = slot.Id;

                                // 更新站位数量
                                slotQty -= reel.Qty;

                                // 移除当前料盘,让其不进入下一次挑料
                                reels.Remove(reel);

                                // 重新计算当前需求数
                                nowDemandSendQty = demandSendQty - reelSendTempDtos.Where(rst => rst.PartNoId == readySlotDDto.PartNoId).Sum(rst => rst.Qty);
                            }
                        }
                    }
                }
            }

            // 计算缺料
            foreach (var readyMB in groupReadyMBs)
            {
                var selectQty = reelSendTempDtos.Where(rst => rst.ReadyMBillDetailedId == readyMB.Id).Sum(rst => rst.Qty);
                var pnOneShortQty = readyMB.DemandQty - readyMB.SendQty + readyMB.ReturnQty - selectQty;

                if (pnOneShortQty > 0)
                {
                    reelShortTemps.Add(new ReelShortTemp()
                    {
                        DemandQty = readyMB.DemandQty,
                        DemandSendQty = readyMB.DemandQty - readyMB.SendQty + readyMB.ReturnQty,
                        IsActive = true,
                        PartNoId = readyMB.PartNoId,
                        ReReadyMBillId = ReReadyMBill.Id,
                        ShortQty = pnOneShortQty,
                        SelectQty = selectQty,
                    });
                }

                // 更新每条数据的最终挑料数量
                foreach (var item in reelSendTempDtos.Where(r => r.ReadyMBillDetailedId == readyMB.Id))
                {
                    item.SelectQty = selectQty;
                }
            }


            foreach (var item in reelSendTempDtos)
            {
                await _repositoryRST.InsertAsync(item);
            }

            foreach (var item in reelShortTemps)
            {
                await _repositoryRSHT.InsertAsync(item);
            }

            readyMResultDto.Success = true;
            readyMResultDto.Msg = "备料成功,打开备料看吧查询详情.";

            await CurrentUnitOfWork.SaveChangesAsync();

            // 亮灯
            var lights = await _repositorySL.GetAllListAsync(s => s.BrightState != BrightState.Off);

            //小灯
            var simlights = lights.Select(l => new StorageLight() { ContinuedTime = 10, lightOrder = 1, MainBoardId = l.MainBoardId, RackPositionId = l.PositionId }).ToList();

            LightService.LightOrder(simlights);

            var houselights = simlights.Select(l => new HouseLight() { HouseLightSide = 1, lightOrder = 1, MainBoardId = l.MainBoardId }).Distinct().ToList();

            LightService.HouseOrder(houselights);

            return readyMResultDto;
        }


        public async Task<ReadyMResultDto> ReadyFirstM(ReadyMDto readyM)
        {
            if (readyM.ReadyMBills.GroupBy(s => new { s.Linestr }).Count() > 1)
            {
                throw new LYException("合并工单必须为相同线别");
            }


            // 判断本次备料单是否全部有备料记录
            var rms = await _repositoryReadyMBill.GetAll().Where(r => readyM.ReadyMBills.Select(rm => rm.Id).Contains(r.Id) && r.ReReadyMBillId != null).Select(r => r.ReReadyMBillId).Distinct().ToListAsync();

            // 有过备料记录的
            if (rms.Count > 1)
            {
                // 本次备料勾选混乱
                throw new LYException("若本次备料包含多个备料单,那么本次备料必须和历史备料勾选一致");
            }
            else if (rms.Count == 1)
            {
                if (rms[0] != readyM.ReReadyMBill)
                {
                    throw new LYException("本次备料记账备料单[" + readyM.ReReadyMBill + "]和历史记账备料单[" + rms[0] + "]不一致");
                }
            }
            // 清除现有灯状态
            var la = await _repositorySL.GetAllListAsync(s => s.BrightState != BrightState.Off);
            foreach (var sl in la)
            {
                sl.BrightState = BrightState.Off;
            }

            await _repositoryRST.DeleteAsync(r => true);

            await _repositoryRSHT.DeleteAsync(r => true);

            await CurrentUnitOfWork.SaveChangesAsync();

            // 备首套料
            ReadyMResultDto readyMResultDto = new ReadyMResultDto() { ReReadyMBillId = readyM.ReReadyMBill };
            List<ReelSendTemp> reelSendTempDtos = new List<ReelSendTemp>();
            List<ReelShortTemp> reelShortTemps = new List<ReelShortTemp>();

            // 记账备料单
            var ReReadyMBill = await _repositoryReadyMBill.GetAll().Where(r => r.Id == readyM.ReReadyMBill).Include(r => r.WorkBills).ThenInclude(w => w.WorkBill).FirstOrDefaultAsync();

            // 添加备料绑定关系

            foreach (var readyItemDto in readyM.ReadyMBills)
            {
                var readyItem = await _repositoryReadyMBill.FirstOrDefaultAsync(readyItemDto.Id);

                if (readyItem.ReReadyMBillId != null && readyItem.ReReadyMBillId != ReReadyMBill.Id)
                {
                    throw new LYException(string.Format("所选备料单[{0}]已与[{1}]合并备料,不能再和[{2}]合并备料", readyItem.Id, readyItem.ReReadyMBillId, ReReadyMBill.Id));
                }

                readyItem.ReReadyMBillId = ReReadyMBill.Id;
                // _repositoryReadyMBill.Update(readyItem);
            }

            // 获取首套料工单
            var firstWoBill = ReReadyMBill.WorkBills.FirstOrDefault().WorkBill;

            // 查询UPH值
            var uph = await _repositoryUPH.FirstOrDefaultAsync(r => r.ProductId == firstWoBill.ProductId && r.LineId == firstWoBill.LineId);

            if (uph == null)
            {
                throw new LYException(string.Format("机种[{0}];线别{1}未维护UPH信息", firstWoBill.ProductId, firstWoBill.LineId));
            }

            // 调拨策略
            var ReelMoveMethod = await _repositoryRMM.GetAll().Where(rmm => rmm.Id == ReReadyMBill.ReelMoveMethodId).Include(s => s.OutStorages).FirstOrDefaultAsync();

            // 查询最低备料数量
            var readyFirstMinimumQty = int.Parse((await _repositoryT.FirstOrDefaultAsync(c => c.TenantId == AbpSession.TenantId && c.Name == "readyFirstMinimumQty")).Value);


            // 查询提前预警天数
            // var overdueDay = int.Parse((await _repositoryT.FirstOrDefaultAsync(c => c.TenantId == AbpSession.TenantId && c.Name == "overdueDay")).Value);

            // 查询当前工单的物料需求详情
            var readyMBs = await _repositoryReadyMBilld.GetAll().Where(r => readyM.ReadyMBills.Select(rm => rm.Id).Contains(r.ReadyMBillId))
                .ToListAsync();

            var groupReadyMBs = readyMBs.GroupBy(s => s.PartNoId).Select(s => new ReadyMBillDetailedDto()
            {
                Id = s.FirstOrDefault().Id,
                PartNoId = s.Key,
                DemandQty = s.Sum(rm => rm.Qty),
                SendQty = s.Sum(rm => rm.SendQty),
                ReturnQty = s.Sum(rm => rm.ReturnQty)
            }).ToList();

            // 查询料站表
            var slots = await _repositorySlot.GetAll().Where(s => s.ProductId == firstWoBill.ProductId && s.LineId == firstWoBill.LineId && s.IsActive)
                .OrderBy(r => (int)r.BoardSide * -1)
                .ThenBy(r => r.Index)
                .ToListAsync();

            // 记账小车库位料站表关联
            Dictionary<string, StorageLocation> dicShelfCarSlotMap = new Dictionary<string, StorageLocation>();

            // 查询小车库位
            var shelfCars = await _repositorySL.GetAll().Where(s => s.Code == readyM.ShelfCar).ToListAsync();

            if (shelfCars.Count == 0)
            {
                throw new LYException(string.Format("输入小车{0}不存在", readyM.ShelfCar));
            }

            // 小车全部灭灯
            foreach (var car in shelfCars)
            {
                car.BrightState = BrightState.Off;
            }

            // 第一个table
            string lastTable = slots[0].Machine + slots[0].Table;
            int nowPositionId = 1;
            // 小车进行料站表绑定并且空位保存
            foreach (var slot in slots)
            {
                string nowTable = slot.Machine + slot.Table;
                var shelfCar = shelfCars.FirstOrDefault(r => r.PositionId == nowPositionId);
                if (lastTable == nowTable)
                {
                    dicShelfCarSlotMap.Add(slot.Id, shelfCar);
                }
                else
                {
                    // 标记为亮灯
                    shelfCar.BrightState = BrightState.On;
                    // 多用一个位置
                    nowPositionId++;
                    lastTable = nowTable;
                    shelfCar = shelfCars.FirstOrDefault(r => r.PositionId == nowPositionId);
                    dicShelfCarSlotMap.Add(slot.Id, shelfCar);
                }
                nowPositionId++;
            }

            // 按料需求详情生成发料料站表
            foreach (var readym in groupReadyMBs)
            {
                // 查询该料号的料站表

                var onePNSlot = slots.Where(s => s.PartNoId == readym.PartNoId);

                foreach (var slot in onePNSlot)
                {
                    var sendSlot = await _repositoryReadySlot.GetAll().FirstOrDefaultAsync(rs => rs.SlotId == slot.Id && rs.ReReadyMBillId == ReReadyMBill.Id);
                    if (sendSlot == null)
                    {
                        var sendSlotN = Mapper.Map<ReadySlot>(slot);
                        if (sendSlotN != null)
                        {
                            sendSlotN.Id = null;
                            sendSlotN.SlotId = slot.Id;
                            sendSlotN.ReReadyMBillId = ReReadyMBill.Id;
                            sendSlotN.SendPartNoId = readym.PartNoId;
                            sendSlotN.DemandQty = readym.DemandQty;
                            sendSlotN.ReadyMBillDetailedId = readym.Id;
                            await _repositoryReadySlot.InsertAsync(sendSlotN);
                            // break;
                        }
                    }
                }
            }

            await CurrentUnitOfWork.SaveChangesAsync();

            // 按料站表备首套料
            foreach (var slot in slots)
            {
                // 查询替代料关系
                var readySlots = await _repositoryReadySlot.GetAll().Where(r => r.SlotId == slot.Id && r.DemandQty > 0 && r.ReReadyMBillId == ReReadyMBill.Id).ToListAsync();

                foreach (var readySlot in readySlots)
                {
                    // 获取MPQ数量
                    var mpn = await _repositoryMPN.FirstOrDefaultAsync(readySlot.SendPartNoId);

                    // 查询库存中该料号符合条件物料并且按照 d/c 排序
                    var reels = await _repositoryReel.GetAll().Where(r =>
                       r.StorageLocationId.Length > 0            // 有库位
                       && r.IsActive     // 有效
                       && r.PartNoId == readySlot.SendPartNoId   // 料号正确
                       && (r.Qty >= readyFirstMinimumQty)
                       && ReelMoveMethod.OutStorages.Select(s => s.StorageId).Contains(r.StorageId)
                     ) // 没有过期物料 d/c 加保质期  加 延续时间 减 提前预警时间 大于 当前时间为合格
                      .ToListAsync();

                    //&& ReelMoveMethod.OutStorages.Select(s => s.StorageId).Contains(r.StorageId)  // 仓库正确
                    // && (r.Qty > readyFirstMinimumQty || r.Qty == mpn.MPQ1.Value)  // 数量大于最小发料数量 或者 为原包装

                    reels = reels.Where(r => r.MakeDate.AddDays(mpn.ShelfLife + r.ExtendShelfLife) > DateTime.Now && reelSendTempDtos.FirstOrDefault(s => s.Id == r.Id) == null)
                      .OrderBy(r => r.MakeDate).ToList(); // 按d/c 进行先进先出排序



                    var reel = reels.FirstOrDefault();

                    if (reel != null)  // 有找到物料,直接备出第一盘料,且跳出当前循环
                    {

                        // 添加发料信息
                        reelSendTempDtos.Add(new ReelSendTemp()
                        {
                            Id = reel.Id,
                            IsActive = true,
                            PartNoId = reel.PartNoId,
                            DemandQty = readySlot.DemandQty,
                            DemandSendQty = reel.Qty,
                            IsSend = false,
                            Qty = reel.Qty,
                            SendQty = reel.Qty,
                            StorageLocationId = reel.StorageLocationId,
                            ReelMoveMethodId = ReReadyMBill.ReelMoveMethodId,
                            ReReadyMBillId = ReReadyMBill.Id,
                            ReadyMBillDetailedId = readySlot.ReadyMBillDetailedId,
                            SlotId = slot.Id,
                            FisrtStorageLocationId = dicShelfCarSlotMap[slot.Id].Id
                        });

                        reel.SlotId = slot.Id;

                        // 标记亮灯,真正的亮灯操作。移到专门的亮灯客户端
                        var sl = _repositorySL.Get(reel.StorageLocationId);
                        sl.BrightState = BrightState.On;
                        // _repositorySL.Update(sl);
                        break;
                    }

                }

                // 查询是否找到首料
                var firstReel = reelSendTempDtos.FirstOrDefault(r => r.SlotId == slot.Id);
                if (firstReel == null)
                {
                    // 如果没有找到首料,添加该站位的首料缺料信息
                    var ReelShortTemp = new ReelShortTemp()
                    {
                        DemandQty = readySlots.Sum(s => s.DemandQty),  // 用所有料的数量总和代替
                        DemandSendQty = readyFirstMinimumQty,  // 需发为最小数量
                        IsActive = true,
                        PartNoId = readySlots.Select(s => s.SendPartNoId).FirstOrDefault() == null ? slot.PartNoId : readySlots.Select(s => s.SendPartNoId).FirstOrDefault(), // 为所有可发物料
                        ReReadyMBillId = ReReadyMBill.Id,
                        ShortQty = readyFirstMinimumQty,
                        SlotId = slot.Id,
                        SelectQty = 0
                    };

                    reelShortTemps.Add(ReelShortTemp);
                }
            }

            foreach (var item in reelSendTempDtos)
            {
                await _repositoryRST.InsertAsync(item);
            }

            foreach (var item in reelShortTemps)
            {
                await _repositoryRSHT.InsertAsync(item);
            }

            readyMResultDto.Success = true;
            readyMResultDto.Msg = "备料成功,打开备料看吧查询详情.";

            await CurrentUnitOfWork.SaveChangesAsync();

            // 亮灯
            var lights = await _repositorySL.GetAllListAsync(s => s.BrightState != BrightState.Off);

            //小灯
            var simlights = lights.Select(l => new
            {
                l.MainBoardId,
                RackPositionId = l.PositionId
            }).Select(s => new StorageLight()
            {
                ContinuedTime = 10,
                lightOrder = 1,
                MainBoardId = s.MainBoardId,
                RackPositionId = s.RackPositionId
            }).ToList();

            LightService.LightOrder(simlights);

            //await _notificationService.SendNotification("LightOrder", simlights);

            //// 灯塔
            var houselights = simlights.Where(r => r.MainBoardId.ToString().Length != 3).Select(l => new
            {
                l.MainBoardId
            }).Distinct()
            .Select(s => new HouseLight()
            {
                MainBoardId = s.MainBoardId,
                HouseLightSide = 1,
                lightOrder = 1
            })
            .ToList();
            //await _notificationService.SendNotification("HouseOrder", houselights);
            LightService.HouseOrder(houselights);

            return readyMResultDto;
        }
    }
}
