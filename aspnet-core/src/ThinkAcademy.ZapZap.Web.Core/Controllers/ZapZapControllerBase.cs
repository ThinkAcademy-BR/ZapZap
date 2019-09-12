using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ThinkAcademy.ZapZap.Controllers
{
    public abstract class ZapZapControllerBase: AbpController
    {
        protected ZapZapControllerBase()
        {
            LocalizationSourceName = ZapZapConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
