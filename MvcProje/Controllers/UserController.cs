using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserProfileManager userprofileManager = new UserProfileManager();
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        Context _context = new Context();
        // GET: User
        public ActionResult Index()
        {
            var mail = (string)Session["Mail"];
            var adsoyad = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorName).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            var image = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorImage).FirstOrDefault();
            ViewBag.image = image;
            return View();
        }
        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profilevalues = userprofileManager.GetAuthorByMail(p);
            return PartialView(profilevalues);
        }
        public ActionResult UpdateUserProfile(Author p)
        {
            userprofileManager.EditAuthor(p);
            return RedirectToAction("Index");
        }
        public ActionResult BlogList(string p)
        {
            var mail = (string)Session["Mail"];
            var adsoyad = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorName).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            var image = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorImage).FirstOrDefault();
            ViewBag.image = image;
            p = (string)Session["Mail"];
            int id = _context.Authors.Where(x => x.Mail == p).Select(y => y.AuthorID).FirstOrDefault();
            var blogs = userprofileManager.GetBlogByAuthor(id);
            return View(blogs);
        }
        public void GetCategoryList()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values;
        }
        public void GetAuthorList()
        {
            Context c = new Context();
            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var mail = (string)Session["Mail"];
            var adsoyad = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorName).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            var image = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorImage).FirstOrDefault();
            ViewBag.image = image;
            Blog blog = blogManager.GetByID(id);
            GetCategoryList();
            GetAuthorList();
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            blogManager.BlogUpdate(blog);
            return RedirectToAction("BlogList");
        }
        [HttpGet]
        public ActionResult AddNewBlog()
        {
            var mail = (string)Session["Mail"];
            var adsoyad = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorName).FirstOrDefault();
            ViewBag.adsoyad = adsoyad;
            var image = _context.Authors.Where(x => x.Mail == mail).Select(y => y.AuthorImage).FirstOrDefault();
            ViewBag.image = image;
            GetCategoryList();
            GetAuthorList();
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog blog)
        {
            blogManager.BlogAddBL(blog);
            return RedirectToAction("BlogList");
        }
    }
}