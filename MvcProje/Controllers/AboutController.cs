using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutManager = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Footer()
        {
            var aboutcontentlist = aboutManager.GetAll();
            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}