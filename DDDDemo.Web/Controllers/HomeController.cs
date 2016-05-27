using System.Web.Mvc;

namespace DDDDemo.Web.Controllers
{
    public class HomeController : DDDDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}