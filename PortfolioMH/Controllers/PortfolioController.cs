using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioMH.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult References()
        {
            return View();
        }
    }
}