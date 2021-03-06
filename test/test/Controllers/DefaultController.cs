﻿using System;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class DefaultController : Controller
    {
        static Transactions trans = new Transactions();
        // GET: Default
        //public ActionResult Index()
        //{
        //   trans = Database.transactionsDB(trans); //objektet trans bliver fyldt med data
        //    return Index();
        //}
        //GET invitation
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        //GET invitation
        [HttpPost]
        public ActionResult Index(test.Models.GuestResponse gr)
        {
            if (ModelState.IsValid)
            {
                return View("thank", gr);
            }
            else
            {
                return View();
            }
        }

    }
}