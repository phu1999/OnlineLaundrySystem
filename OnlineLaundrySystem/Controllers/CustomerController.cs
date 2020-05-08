using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineLaundrySystem.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomersList()
        {
            return View();
        }
        public ActionResult CustomerInfo()
        {
            return View();
        }
    }
}