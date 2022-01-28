using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class MailSubscribeController : Controller
    {
        // GET: MailSubscribe
        SubscribeMailManager subscribemailManager = new SubscribeMailManager();
        [HttpGet]
        [AllowAnonymous]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        [AllowAnonymous]
        public PartialViewResult AddMail(SubscribeMail subscribemail)
        {
            subscribemailManager.BLAdd(subscribemail);
            return PartialView();
        }
    }
}