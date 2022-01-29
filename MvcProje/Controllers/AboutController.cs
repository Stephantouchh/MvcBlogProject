using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        AuthorManager authorManager = new AuthorManager(new EfAuthorDal());
        [AllowAnonymous]
        public ActionResult Index()
        {
            var aboutcontent = aboutManager.GetAll();
            return View(aboutcontent);
        }
        [AllowAnonymous]
        public PartialViewResult Footer()
        {
            var aboutcontentlist = aboutManager.GetAll();
            return PartialView(aboutcontentlist);
        }
        [AllowAnonymous]
        public PartialViewResult MeetTheTeam()
        {
            var authorlist = authorManager.GetList().Take(6);
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