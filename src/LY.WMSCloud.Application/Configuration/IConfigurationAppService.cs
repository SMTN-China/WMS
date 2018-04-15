using System.Threading.Tasks;
using LY.WMSCloud.Configuration.Dto;

namespace LY.WMSCloud.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
