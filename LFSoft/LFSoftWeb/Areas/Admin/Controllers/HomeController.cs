using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LFSoftWeb.Filters;

namespace LFSoftWeb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [AcessoRestritoFilter]
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}