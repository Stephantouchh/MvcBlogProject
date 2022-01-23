using BusinessLayer.Concrete;
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
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail = blogManager.GetBlogByID(id);
            return PartialView(authordetail);
        }
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = blogManager.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            var authorblogs = blogManager.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }
    }
}