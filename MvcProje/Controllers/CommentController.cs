using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        // GET: Comment
        [AllowAnonymous]
        public PartialViewResult CommentList(int id)
        {
            var commentlist = commentManager.CommentByBlog(id).Where(x => x.CommentStatus == true);
            return PartialView(commentlist);
        }
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {
            CommentValidator commentvalidator = new CommentValidator();
            ValidationResult results = commentvalidator.Validate(comment);
            if (results.IsValid)
            {
                comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                comment.CommentStatus = true;
                commentManager.TAdd(comment);
                return PartialView();
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return PartialView();
        }
        public ActionResult AdminCommentListTrue()
        {
            var commentlist = commentManager.CommentByStatusTrue();
            return View(commentlist);
        }
        public ActionResult AdminCommentListFalse()
        {
            var commentlist = commentManager.CommentByStatusFalse();
            return View(commentlist);
        }
        public ActionResult StatusChangeToFalse(int id)
        {
            commentManager.CommentStatusChangeToFalse(id);
            return RedirectToAction("AdminCommentListTrue");
        }
        public ActionResult StatusChangeToTrue(int id)
        {
            commentManager.CommentStatusChangeToTrue(id);
            return RedirectToAction("AdminCommentListFalse");
        }
    }
}