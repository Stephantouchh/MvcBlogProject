using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class UserController : Controller
    {
        UserProfileManager userprofileManager = new UserProfileManager();

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profilevalues = userprofileManager.GetAuthorByMail(p);
            return PartialView(profilevalues);
        }
    }
}