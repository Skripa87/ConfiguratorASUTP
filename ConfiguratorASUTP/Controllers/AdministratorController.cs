using ConfiguratorASUTP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ConfiguratorASUTP.Controllers
{
    [AllowAnonymous]
    public class AdministratorController : Controller
    {
                // GET: Administrator
        public ActionResult CreateNewPart()
        {
            return View();
        }
        public ActionResult CreatePart()
        {
            var x = ViewData["PartBasicProperties"];
            return View();
        }

    }
}