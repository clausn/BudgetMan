using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class DefaultController : Controller
    {
        static Transactions trans = new Transactions();
        // GET: Default
        public ActionResult Index()
        {
           trans = Database.transactionsDB(trans); //objektet trans bliver fyldt med data
            return Index();
        }
    }
}