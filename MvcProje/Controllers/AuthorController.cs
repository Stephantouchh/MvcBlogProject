using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager blogManager = new BlogManager();
        AuthorManager authorManager = new AuthorManager();
        [AllowAnonymous]
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = blogManager.GetBlogByID(id);
            return PartialView(authordetail);
        }
        [AllowAnonymous]
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = blogManager.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorblogs = blogManager.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }
        public ActionResult AuthorList()
        {
            var authorlist = authorManager.GetAll();
            return View(authorlist);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author author)
        {
            authorManager.AddAuthorBL(author);
            return RedirectToAction("AuthorList");
        }
        [HttpGet]
        public ActionResult AuthorEdit(int id)
        {
            Author author = authorManager.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult AuthorEdit(Author author)
        {
            authorManager.EditAuthor(author);
            return RedirectToAction("AuthorList");
        }
    }
}