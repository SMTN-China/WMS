using LY.WMSCloud.Entities.BaseData;
using LY.WMSCloud.Entities.StorageData;
using LY.WMSCloud.WMS.BaseData.Lines.Dto;
using LY.WMSCloud.WMS.BaseData.Storages.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LY.WMSCloud.WMS.BaseData.Lines
{
    public class LineAppService : ServiceBase<Line, LineDto, string>, ILineAppService
    {
        readonly IWMSRepositories<Line, string> _repository;
        readonly IWMSRepositories<Storage, string> _repositoryStorage;
        public LineAppService(IWMSRepositories<Line, string> repository, IWMSRepositories<Storage, string> repositoryStorage) : base(repository)
        {
            _repository = repository;
            _repositoryStorage = repositoryStorage;
        }

        public async Task<ICollection<StorageDto>> GetCStorageByKeyName(string keyName)
        {
            var res = await _repositoryStorage.GetAll().Where(c => (c.IncomingMethod == IncomingMethod.ForCustomer || c.IncomingMethod == IncomingMethod.Other) && c.Id.Contains(keyName)).Take(10).ToListAsync();

            return ObjectMapper.Map<List<StorageDto>>(res);
        }

        public async Task<ICollection<LineDto>> GetLineByKeyName(string keyName)
        {
            var res = await _repository.GetAll().Where(l => l.Id.Contains(keyName)).Take(10).ToListAsync();

            return ObjectMapper.Map<List<LineDto>>(res);
        }

        public async Task<ICollection<StorageDto>> GetSStorageByKeyName(string keyName)
        {
            var res = await _repositoryStorage.GetAll().Where(c => (c.IncomingMethod == IncomingMethod.ForSelf || c.IncomingMethod == IncomingMethod.Other) && c.Id.Contains(keyName)).Take(10).ToListAsync();
            return ObjectMapper.Map<List<StorageDto>>(res);
        }
    }
}
