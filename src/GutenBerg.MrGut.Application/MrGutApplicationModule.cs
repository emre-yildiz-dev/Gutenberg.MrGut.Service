using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GutenBerg.MrGut.Authorization;

namespace GutenBerg.MrGut
{
    [DependsOn(
        typeof(MrGutCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MrGutApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MrGutAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MrGutApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
