using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        Context _context = new Context();
        // GET: Login
        [HttpGet]
        public ActionResult AuthorLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorLogin(Author p)
        {
            var userinfo = _context.Authors.FirstOrDefault(x => x.Mail == p.Mail && x.Password == p.Password);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Mail, false);
                Session["Mail"] = userinfo.Mail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorLogin", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AuthorLogin");
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin p)
        {
            var admininfo = _context.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(admininfo.UserName, false);
                Session["UserName"] = admininfo.UserName.ToString();
                return RedirectToAction("AdminBlogList", "Blog");
            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }
        }
        public ActionResult AdminLogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AdminLogin");
        }
    }
}