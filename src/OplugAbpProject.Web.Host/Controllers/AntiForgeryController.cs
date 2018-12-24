using Microsoft.AspNetCore.Antiforgery;
using OplugAbpProject.Controllers;

namespace OplugAbpProject.Web.Host.Controllers
{
    public class AntiForgeryController : OplugAbpProjectControllerBase
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
