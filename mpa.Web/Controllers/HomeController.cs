using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace mpa.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : mpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}