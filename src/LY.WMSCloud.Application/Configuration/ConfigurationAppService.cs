using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using LY.WMSCloud.Configuration.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LY.WMSCloud.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WMSCloudAppServiceBase, IConfigurationAppService
    {
        readonly IRepository<Setting, long> _repositoryT;

        public ConfigurationAppService(IRepository<Setting, long> repositoryT)
        {
            _repositoryT = repositoryT;
        }

        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }

        [HttpPost]
        public async Task<ICollection<ISettingValue>> GetAppConfig(string[] names)
        {
            List<ISettingValue> list = new List<ISettingValue>();
            var all = await _repositoryT.GetAll().Where(c => c.TenantId == AbpSession.TenantId.Value).ToListAsync();


            foreach (var name in names)
            {
                var value = all.FirstOrDefault(c => c.Name == name);
                if (value != null)
                {
                    list.Add(new SettingValue() { Name = name, Value = value.Value });
                }
                else
                {
                    list.Add(new SettingValue() { Name = name, Value = "" });
                }
            }

            return list;
        }

        [HttpPost]
        public async Task SetAppConfig(SettingValue[] settings)
        {
            foreach (var setting in settings)
            {
                var con = _repositoryT.GetAll().FirstOrDefault(c => c.Name == setting.Name && c.TenantId == AbpSession.TenantId);
                if (con == null)
                {
                    await _repositoryT.InsertAsync(new Setting() { Name = setting.Name, Value = setting.Value, TenantId = AbpSession.TenantId });
                }
                else
                {
                    con.Value = setting.Value;
                    await _repositoryT.UpdateAsync(con);
                }
            }
        }
    }
}
