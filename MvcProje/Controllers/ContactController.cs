using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager();
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            contactManager.BLContactAdd(contact);
            return View();
        }
        public ActionResult SendBox()
        {
            var messagelist = contactManager.GetAll();
            return View(messagelist);
        }
    }
}