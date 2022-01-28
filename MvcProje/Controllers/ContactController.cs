﻿using BusinessLayer.Concrete;
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
            contactManager.BLContactAdd(contact);
            return View();
        }
        public ActionResult SendBox()
        {
            var messagelist = contactManager.GetAll();
            return View(messagelist);
        }
        public ActionResult MessageDetails(int id)
        {
            Contact contact = contactManager.GetContactDetails(id);
            return View(contact);
        }
        public PartialViewResult GetMessageSideBar()
        {
            return PartialView();
        }
    }
}