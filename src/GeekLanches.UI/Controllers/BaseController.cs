using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeekLanches.UI.Controllers
{
    public class BaseController : Controller
    {

    }

    public static class HttpExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
                return false;
            else if (request.Headers != null)
                return request.Headers["X-Requested-With"] == "XMLHttpRequest";
            return false;
        }
    }
}
