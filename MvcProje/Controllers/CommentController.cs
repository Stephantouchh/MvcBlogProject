using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager();
        // GET: Comment
        public PartialViewResult CommentList(int id)
        {
            var commentlist = commentManager.CommentByBlog(id).Where(x=>x.CommentStatus==true);
            return PartialView(commentlist);
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            commentManager.CommentAdd(comment);
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