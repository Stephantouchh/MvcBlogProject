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
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        // GET: Contact

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult SendMessage(Contact contact)
        {
            ContactValidator contactvalidator = new ContactValidator();
            ValidationResult results = contactvalidator.Validate(contact);
            if (results.IsValid)
            {
                contact.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                contactManager.TAdd(contact);
                return RedirectToAction("SendMessage");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult SendBox()
        {
            var messagelist = contactManager.GetList();
            return View(messagelist);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact contact = contactManager.GetByID(id);
            return View(contact);
        }
        public PartialViewResult GetMessageSideBar()
        {
            return PartialView();
        }
    }
}