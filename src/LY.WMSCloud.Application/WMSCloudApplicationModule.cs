using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LY.WMSCloud.Authorization;

namespace LY.WMSCloud
{
    [DependsOn(
        typeof(WMSCloudCoreModule),
        typeof(AbpAutoMapperModule))]
    public class WMSCloudApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WMSCloudAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WMSCloudApplicationModule).GetAssembly();

            IocManager.Register(typeof(IServiceBase<,,,>), typeof(ServiceBase<,,,,>),Abp.Dependency.DependencyLifeStyle.Transient);
            IocManager.Register(typeof(IServiceBase<,,>), typeof(ServiceBase<,,,>), Abp.Dependency.DependencyLifeStyle.Transient);
            IocManager.Register(typeof(IServiceBase<,>), typeof(ServiceBase<,,>), Abp.Dependency.DependencyLifeStyle.Transient);

            IocManager.Register(typeof(IDefaultServiceBase<,,>), typeof(DefaultServiceBase<,,,>), Abp.Dependency.DependencyLifeStyle.Transient);
            IocManager.Register(typeof(IDefaultServiceBase<,>), typeof(DefaultServiceBase<,,>), Abp.Dependency.DependencyLifeStyle.Transient);
            IocManager.Register(typeof(IDefaultServiceBase<>), typeof(DefaultServiceBase<,>), Abp.Dependency.DependencyLifeStyle.Transient);

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
