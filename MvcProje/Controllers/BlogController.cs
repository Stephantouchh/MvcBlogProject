using BusinessLayer.Concrete;
using PagedList;
using PagedList.Mvc;
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
        public PartialViewResult BlogList(int page = 1)
        {
            var bloglist = blogManager.GetAll().ToPagedList(page, 6);
            return PartialView(bloglist);
        }
        public PartialViewResult FeaturedPost()
        {
            //3.Kategori
            //1.Post
            var posttitle1 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();

            //6.Kategori
            //2.Post
            var posttitle2 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogDate).FirstOrDefault();

            //2.Kategori
            //3.Post
            var posttitle3 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();

            //4.Kategori
            //4.Post
            var posttitle4 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();

            //5.Kategori
            //5.Post
            var posttitle5 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate5 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogDate).FirstOrDefault();



            //3.Post
            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;

            //2.Post
            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;

            //5.Post
            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;

            //4.Post
            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;

            //5.Post
            ViewBag.posttitle5 = posttitle5;
            ViewBag.postimage5 = postimage5;
            ViewBag.blogdate5 = blogdate5;

            return PartialView();
        }
        public PartialViewResult OtherFeaturedPost()
        {
            //1.Kategori
            //1.Post
            var posttitle1 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();

            //8.Kategori
            //2.Post
            var posttitle2 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 8).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 8).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 8).Select(y => y.BlogDate).FirstOrDefault();

            //9.Kategori
            //3.Post
            var posttitle3 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 9).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 9).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 9).Select(y => y.BlogDate).FirstOrDefault();

            //7.Kategori
            //4.Post
            var posttitle4 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 7).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 7).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = blogManager.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 7).Select(y => y.BlogDate).FirstOrDefault();

            //1.Kategori
            //1.Post
            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;

            //8.Kategori
            //2.Post
            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;

            //9.Kategori
            //3.Post
            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;

            //7.Kategori
            //4.Post
            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;

            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover(int id)
        {
            var BlogDetailsList = blogManager.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = blogManager.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }
    }
}