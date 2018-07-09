using Abp.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LY.WMSCloud
{
    public class WmsSettingProvider : SettingProvider
    {
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
                    {
                    new SettingDefinition(
                        "reelMoveMethodId",
                        "",
                        scopes: SettingScopes.Tenant
                        )
                };
        }
    }
}
