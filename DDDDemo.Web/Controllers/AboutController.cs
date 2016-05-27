using System.Web.Mvc;

namespace DDDDemo.Web.Controllers
{
    public class AboutController : DDDDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}