using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LY.WMSCloud.Configuration.Dto;

namespace LY.WMSCloud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WMSCloudAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
