using System.Web.Mvc;

namespace mpa.Web.Controllers
{
    public class AboutController : mpaControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}