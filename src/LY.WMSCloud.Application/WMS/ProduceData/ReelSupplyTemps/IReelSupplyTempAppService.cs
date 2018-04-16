using LY.WMSCloud.WMS.ProduceData.ReelSupplyTemps.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LY.WMSCloud.WMS.ProduceData.ReelSupplyTemps
{
    public interface IReelSupplyTempAppService : IServiceBase<ReelSupplyTempDto, string>
    {
        Task<ReelSupplyResultDto> Supply(ReelSupplyInputDto[] input);
    }
}
