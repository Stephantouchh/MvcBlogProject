using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager blogManager = new BlogManager();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList()
        {
            var bloglist = blogManager.GetAll();
            return PartialView(bloglist);
        }
        public PartialViewResult FeaturedPost()
        {
            return PartialView();
        }
        public PartialViewResult OtherFeaturedPost()
        {
            return PartialView();
        }
        public PartialViewResult MailSubscribe()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover()
        {
            return PartialView();
        }
        public PartialViewResult BlogReadAll()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}