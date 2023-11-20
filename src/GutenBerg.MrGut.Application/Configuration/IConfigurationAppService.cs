using System.Threading.Tasks;
using GutenBerg.MrGut.Configuration.Dto;

namespace GutenBerg.MrGut.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
