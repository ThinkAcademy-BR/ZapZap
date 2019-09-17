using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ThinkAcademy.ZapZap.Configuration.Dto;

namespace ThinkAcademy.ZapZap.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZapZapAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
