using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager categoryManager = new CategoryManager();

        public ActionResult Index()
        {
            var categoryvalues = categoryManager.GetAll();
            return View(categoryvalues);
        }
        [AllowAnonymous]
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryvalues = categoryManager.GetAll().Where(x => x.CategoryStatus == true);
            return PartialView(categoryvalues);
        }
        public ActionResult AdminCategoryList()
        {
            var categorylist = categoryManager.GetAll();
            return View(categorylist);
        }
        [HttpGet]
        public ActionResult AdminCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminCategoryAdd(Category category)
        {
            categoryManager.CategoryAddBL(category);
            return RedirectToAction("AdminCategoryList");
        }
        [HttpGet]
        public ActionResult CategoryEdit(int id)
        {
            Category category = categoryManager.FindCategory(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult CategoryEdit(Category category)
        {
            categoryManager.EditCategory(category);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult CategoryDelete(int id)
        {
            var result = categoryManager.GetByID(id);

            if (result.CategoryStatus == true)
            {
                result.CategoryStatus = false;
            }
            else
            {
                result.CategoryStatus = true;
            }
            categoryManager.DeleteCategoryBL(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}