using Abp.Localization;
using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LY.WMSCloud.Sys.I18Ns.Dto;

namespace LY.WMSCloud.Sys.I18Ns
{
    public class I18NAppService : ServiceBase<ApplicationLanguageText, I18NDto, long>, II18NAppService
    {
        readonly IWMSRepositories<ApplicationLanguageText, long> _repository;
        public I18NAppService(IWMSRepositories<ApplicationLanguageText, long> repository) : base(repository)
        {
            _repository = repository;
        }

        public async override Task<I18NDto> Create(I18NDto input)
        {
            // CheckCreatePermission();
            input.TenantId = AbpSession.TenantId;
            input.Source = LocalizationSourceName;
            var lang = await SettingManager.GetSettingValueForUserAsync(LocalizationSettingNames.DefaultLanguage, AbpSession.ToUserIdentifier());
            input.LanguageName = lang;
            return await base.Create(input);
        }

        public async Task<ICollection<I18NDto>> GetByKeyName(string keyName)
        {
            var lang = await SettingManager.GetSettingValueForUserAsync(LocalizationSettingNames.DefaultLanguage, AbpSession.ToUserIdentifier());

            var res = _repository.GetAll().Where(l => l.Key.ToLower().Contains(keyName.ToLower()) && l.LanguageName == lang).ToList();

            return ObjectMapper.Map<List<I18NDto>>(res);
        }
    }
}
