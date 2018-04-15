﻿using Abp.Configuration;
using LY.WMSCloud.Entities.BaseData;
using LY.WMSCloud.WMS.BaseData.Customers.Dto;
using LY.WMSCloud.WMS.BaseData.MPNs.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LY.WMSCloud.WMS.BaseData.MPNs
{
    public class MPNAppService : ServiceBase<MPN, MPNDto, string>, IMPNAppService
    {
        readonly IWMSRepositories<MPN, string> _repository;
        readonly IWMSRepositories<Customer, string> _repositoryCustomer;
        readonly IWMSRepositories<Setting, long> _repositoryT;
        public MPNAppService(IWMSRepositories<MPN, string> repository, IWMSRepositories<Customer, string> repositoryCustomer, IWMSRepositories<Setting, long> repositoryT) : base(repository)
        {
            _repositoryCustomer = repositoryCustomer;
            _repositoryT = repositoryT;
        }

        public async Task<ICollection<CustomerDto>> GetCustomerById(string Id)
        {
            var res = await _repositoryCustomer.GetAll().Where(c => c.Id.Contains(Id)).Take(10).ToListAsync();

            return ObjectMapper.Map<List<CustomerDto>>(res);
        }

        public async Task<ICollection<CustomerDto>> GetCustomerByKeyName(string keyName)
        {
            var res = await _repositoryCustomer.GetAll().Where(c => c.Id.Contains(keyName)).Take(10).ToListAsync();

            return ObjectMapper.Map<List<CustomerDto>>(res);
        }

        public async Task<bool> BatchInsOrUpdate(ICollection<MPNDto> input)
        {
            // 查询备损数量
            string registerStorageId = null;

            // 此处后面可能会进行改动
            var readyLossQty = _repositoryT.FirstOrDefault(c => c.TenantId == AbpSession.TenantId && c.Name == "registerStorageId");
            if (readyLossQty != null)
            {
                registerStorageId = readyLossQty.Value;
            }

            try
            {
                foreach (var item in input)
                {
                    try
                    {
                        var nowMPN = _repository.FirstOrDefault(item.Id);
                        if (nowMPN != null && ((
                                nowMPN.Name != item.Name)
                            || (nowMPN.Info != item.Info)
                            || (nowMPN.MPNHierarchy != item.MPNHierarchy)
                            || (nowMPN.MPNLevel != item.MPNLevel)
                            || (nowMPN.MPQs != item.MPQs)
                            || (nowMPN.MPNType != item.MPNType)
                            ))
                        {
                            nowMPN.Name = item.Name;
                            nowMPN.Info = item.Info;
                            nowMPN.MPNHierarchy = item.MPNHierarchy;
                            nowMPN.MPNLevel = item.MPNLevel;
                            nowMPN.MPQs = item.MPQs;
                            nowMPN.MPNType = item.MPNType;
                            // await _repository.UpdateAsync(nowMPN);
                        }
                        else if (nowMPN == null)
                        {
                            nowMPN = ObjectMapper.Map<MPN>(item);
                            nowMPN.RegisterStorageId = registerStorageId;

                            await _repository.InsertAsync(nowMPN);
                        }
                    }
                    catch (Exception ex)
                    {
                        item.Remark += ex.Message;
                    }
                    CurrentUnitOfWork.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new LYException(ex.Message);
            }

        }

    }
}
