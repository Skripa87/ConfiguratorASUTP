using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConfiguratorASUTP.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult CreateNewPropertyType()
        {
            return View();
        }
    }
}