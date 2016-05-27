using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Authorization;
using Abp.Web.Mvc.Controllers;

namespace DDDDemo.Web.Controllers
{
    public class SystemController : DDDDemoControllerBase
    {
        //
        // GET: /System/
        public ActionResult Index()
        {
            return View();
        }


	}
}