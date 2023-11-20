using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GutenBerg.MrGut.Configuration.Dto;

namespace GutenBerg.MrGut.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MrGutAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
