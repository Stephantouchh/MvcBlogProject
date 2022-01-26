using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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
        AuthorManager authorManager = new AuthorManager();
        public ActionResult Index()
        {
            var aboutcontent = aboutManager.GetAll();
            return View(aboutcontent);
        }
        public PartialViewResult Footer()
        {
            var aboutcontentlist = aboutManager.GetAll();
            return PartialView(aboutcontentlist);
        }
        public PartialViewResult MeetTheTeam()
        {
            var authorlist = authorManager.GetAll();
            return PartialView(authorlist);
        }
        [HttpGet]
        public ActionResult UpdateAboutList()
        {
            var aboutlist = aboutManager.GetAll();
            return View(aboutlist);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About p)
        {
            aboutManager.UpdateAboutBM(p);
            return RedirectToAction("UpdateAboutList");
        }
    }
}