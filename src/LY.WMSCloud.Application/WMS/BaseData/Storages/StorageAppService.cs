using LY.WMSCloud.Entities.StorageData;
using LY.WMSCloud.WMS.BaseData.Storages.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LY.WMSCloud.WMS.BaseData.Storages
{
    public class StorageAppService : ServiceBase<Storage, StorageDto, string>, IStorageAppService
    {
        readonly IWMSRepositories<Storage, string> _repository;
        public StorageAppService(IWMSRepositories<Storage, string> repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<StorageDto>> GetStorageByKeyName(string keyName)
        {
            var res = await _repository.GetAll().Where(c => c.Id.Contains(keyName)).Take(10).ToListAsync();

            return ObjectMapper.Map<List<StorageDto>>(res);
        }
    }
}
