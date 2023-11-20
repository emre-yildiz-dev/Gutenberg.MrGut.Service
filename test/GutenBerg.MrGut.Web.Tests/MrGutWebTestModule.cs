using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GutenBerg.MrGut.EntityFrameworkCore;
using GutenBerg.MrGut.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GutenBerg.MrGut.Web.Tests
{
    [DependsOn(
        typeof(MrGutWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MrGutWebTestModule : AbpModule
    {
        public MrGutWebTestModule(MrGutEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MrGutWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MrGutWebMvcModule).Assembly);
        }
    }
}