using Microsoft.AspNetCore.Antiforgery;
using ThinkAcademy.ZapZap.Controllers;

namespace ThinkAcademy.ZapZap.Web.Host.Controllers
{
    public class AntiForgeryController : ZapZapControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
