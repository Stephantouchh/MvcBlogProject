using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public PartialViewResult CommentList()
        {
            return PartialView();
        }
        public PartialViewResult LeaveComment()
        {
            return PartialView();
        }
    }
}