using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        CommentManager commentManager = new CommentManager();
        Context _context = new Context();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogList(int page = 1)
        {
            var bloglist = blogManager.GetList().Where(x=>x.BlogStatus==true).ToPagedList(page, 6);
            return PartialView(bloglist);
        }
        [AllowAnonymous]
        public PartialViewResult FeaturedPost()
        {
            //3.Kategori
            //1.Post
            var posttitle1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogID).FirstOrDefault();

            //6.Kategori
            //2.Post
            var posttitle2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 6).Select(y => y.BlogID).FirstOrDefault();

            //2.Kategori
            //3.Post
            var posttitle3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogID).FirstOrDefault();

            //4.Kategori
            //4.Post
            var posttitle4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogID).FirstOrDefault();

            //5.Kategori
            //5.Post
            var posttitle5 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate5 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogDate).FirstOrDefault();
            var blogpostid5 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogID).FirstOrDefault();


            //1.Post
            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;
            ViewBag.blogpostid1 = blogpostid1;

            //2.Post
            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;
            ViewBag.blogpostid2 = blogpostid2;

            //3.Post
            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;
            ViewBag.blogpostid3 = blogpostid3;

            //4.Post
            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;
            ViewBag.blogpostid4 = blogpostid4;

            //5.Post
            ViewBag.posttitle5 = posttitle5;
            ViewBag.postimage5 = postimage5;
            ViewBag.blogdate5 = blogdate5;
            ViewBag.blogpostid5 = blogpostid5;

            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult OtherFeaturedPost()
        {
            //1.Kategori
            //1.Post
            var posttitle1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();

            //8.Kategori
            //2.Post
            var posttitle2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 8).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 8).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 8).Select(y => y.BlogDate).FirstOrDefault();

            //9.Kategori
            //3.Post
            var posttitle3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 9).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 9).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 9).Select(y => y.BlogDate).FirstOrDefault();

            //7.Kategori
            //4.Post
            var posttitle4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 7).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 7).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = blogManager.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 7).Select(y => y.BlogDate).FirstOrDefault();

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
        [AllowAnonymous]
        public ActionResult BlogDetails()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult BlogCover(int id)
        {
            var BlogDetailsList = blogManager.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        [AllowAnonymous]
        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = blogManager.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        [AllowAnonymous]
        public ActionResult BlogByCategory(int id)
        {
            var BlogListByCategory = blogManager.GetBlogByCategory(id);
            var CategoryName = blogManager.GetBlogByCategory(id).Select(y => y.Category.CategoryName).FirstOrDefault();
            ViewBag.CategoryName = CategoryName;
            var CategoryDescription = blogManager.GetBlogByCategory(id).Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.CategoryDescription = CategoryDescription;
            return View(BlogListByCategory);
        }
        public ActionResult AdminBlogList()
        {
            var bloglist = blogManager.GetList();
            return View(bloglist);
        }
        public ActionResult AdminBlogList2()
        {
            var bloglist = blogManager.GetList();
            return View(bloglist);
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
        [Authorize(Roles = "A")]
        [HttpGet]
        public ActionResult AddNewBlog()
        {
            GetCategoryList();
            GetAuthorList();
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog blog)
        {
            BlogValidator blogvalidator = new BlogValidator();
            ValidationResult results = blogvalidator.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blogManager.BlogAddBL(blog);
                return RedirectToAction("AdminBlogList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            GetCategoryList();
            GetAuthorList();
            return View();
        }
        public ActionResult DeleteBlog(int id)
        {
            var result = blogManager.GetByID(id);

            if (result.BlogStatus == true)
            {
                result.BlogStatus = false;
            }
            else
            {
                result.BlogStatus = true;
            }
            blogManager.BlogDelete(result);
            return RedirectToAction("AdminBlogList2", "Blog");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = blogManager.GetByID(id);
            GetCategoryList();
            GetAuthorList();
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            BlogValidator blogvalidator = new BlogValidator();
            ValidationResult results = blogvalidator.Validate(blog);
            if (results.IsValid)
            {
                blogManager.BlogUpdate(blog);
                return RedirectToAction("AdminBlogList2");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            GetCategoryList();
            GetAuthorList();
            return View();
        }
        public ActionResult GetCommentByBlog(int id)
        {
            var commentlist = commentManager.CommentByBlog(id);
            return View(commentlist);
        }
        public ActionResult AuthorBlogList(int id)
        {
            var blogs = blogManager.GetBlogByAuthor(id);
            return View(blogs);
        }
    }
}