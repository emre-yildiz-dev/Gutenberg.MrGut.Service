using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GutenBerg.MrGut.Configuration;

namespace GutenBerg.MrGut.Web.Host.Startup
{
    [DependsOn(
       typeof(MrGutWebCoreModule))]
    public class MrGutWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MrGutWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MrGutWebHostModule).GetAssembly());
        }
    }
}
