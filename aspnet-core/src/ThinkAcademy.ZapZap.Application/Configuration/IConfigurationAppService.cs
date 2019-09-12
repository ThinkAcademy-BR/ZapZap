using System.Threading.Tasks;
using ThinkAcademy.ZapZap.Configuration.Dto;

namespace ThinkAcademy.ZapZap.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
