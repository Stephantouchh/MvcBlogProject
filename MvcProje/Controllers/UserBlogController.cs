using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class UserBlogController : Controller
    {
        // GET: UserBlog
        public ActionResult Index()
        {
            return View();
        }
    }
}