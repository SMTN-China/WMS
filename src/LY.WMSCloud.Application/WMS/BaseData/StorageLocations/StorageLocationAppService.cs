﻿using LY.WMSCloud.Base;
using LY.WMSCloud.CommonService;
using LY.WMSCloud.Entities.StorageData;
using LY.WMSCloud.WMS.BaseData.StorageLocations.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LY.WMSCloud.WMS.BaseData.StorageLocations
{
    public class StorageLocationAppService : ServiceBase<StorageLocation, StorageLocationDto, string>, IStorageLocationAppService
    {
        readonly IWMSRepositories<StorageLocationType, string> _repositoryT;
        readonly IWMSRepositories<Storage, string> _repositoryS;
        readonly LightService LightService;
        readonly IWMSRepositories<StorageLocation, string> _repository;
        public StorageLocationAppService(
            IWMSRepositories<StorageLocation, string> repository,
            IWMSRepositories<StorageLocationType, string> repositoryT,
            IWMSRepositories<Storage, string> repositoryS,
            LightService lightService) : base(repository)
        {
            _repositoryT = repositoryT;
            _repository = repository;
            _repositoryS = repositoryS;
            LightService = lightService;
        }

        public async Task AddByLY(LYDto lYDto)
        {
            List<StorageLocationDto> list = new List<StorageLocationDto>();
            for (int i = 0; i < lYDto.ShelfCode.Length; i++)
            {
                for (int j = 1; j <= lYDto.Count; j++)
                {
                    list.Add(new StorageLocationDto()
                    {
                        Code = lYDto.ShelfCode[i],
                        Name = lYDto.ShelfCode[i],
                        Id = lYDto.ShelfId[i] + j.ToString().PadLeft(4, '0'),
                        MainBoardId = j > 700 ? lYDto.mainId[i][1] : lYDto.mainId[i][0],
                        PositionId = j,
                        IsActive = true,
                        StorageId = lYDto.StorageId,
                        StorageLocationTypeId = lYDto.StorageLocationTypeId
                    });
                }
            }



            foreach (var item in list)
            {
                if (_repository.FirstOrDefault(s => s.Id == item.Id) == null)
                {
                    await Create(item);
                }
                else
                {
                    await Update(item);
                }
            }
        }

        public async Task AllBright()
        {
            var lights = await _repository.GetAll().GroupBy(r => r.MainBoardId).Select(r => new AllLight { lightOrder = 1, MainBoardId = r.Key }).Distinct().ToListAsync();

            // 小灯,灯塔
            LightService.AllLightOrder(lights);

            LightService.HouseOrder(lights.Select(r => new HouseLight() { lightOrder = 1, MainBoardId = r.MainBoardId, HouseLightSide = 0 }).ToList());

            LightService.HouseOrder(lights.Select(r => new HouseLight() { lightOrder = 1, MainBoardId = r.MainBoardId, HouseLightSide = 1 }).ToList());
        }

        public async Task AllExtinguished()
        {
            var lights = await _repository.GetAll().GroupBy(r => r.MainBoardId).Select(r => new AllLight { lightOrder = 0, MainBoardId = r.Key }).Distinct().ToListAsync();

            // 小灯
            LightService.AllLightOrder(lights);


            // 灯塔
            LightService.HouseOrder(lights.Select(r => new HouseLight() { lightOrder = 0, MainBoardId = r.MainBoardId, HouseLightSide = 0 }).ToList());

            LightService.HouseOrder(lights.Select(r => new HouseLight() { lightOrder = 0, MainBoardId = r.MainBoardId, HouseLightSide = 1 }).ToList());
        }

        public async Task NonReelBright()
        {
            // 查询所有空库位

            var lights = await _repository.GetAll().Where(r => r.ReelId == null).Select(r => new StorageLight { lightOrder = 1, MainBoardId = r.MainBoardId, ContinuedTime = 10, RackPositionId = r.PositionId }).Distinct().ToListAsync();

            // 小灯
            LightService.LightOrder(lights);


            // 灯塔
            var mains = lights.GroupBy(r => new AllLight { lightOrder = 0, MainBoardId = r.MainBoardId }).Select(r => r.Key).ToList();

            LightService.HouseOrder(lights.Select(r => new HouseLight() { lightOrder = 0, MainBoardId = r.MainBoardId, HouseLightSide = 0 }).ToList());

            LightService.HouseOrder(lights.Select(r => new HouseLight() { lightOrder = 0, MainBoardId = r.MainBoardId, HouseLightSide = 1 }).ToList());
        }

        public async Task<bool> GetIsHave(string id)
        {
            var res = await _repository.FirstOrDefaultAsync(id);

            return res != null;
        }
    }
}
