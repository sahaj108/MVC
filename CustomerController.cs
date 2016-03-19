using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CustomerController : Controller
    {
       
        public ActionResult Index()
        {
            List<Customer> mylist = new List<Customer>();

            mylist.Add(new Customer() { customer_id = 1, customer_name = "ABC", salary = 4500 });
            mylist.Add(new Customer() { customer_id = 2, customer_name = "CDE", salary = 5000 });
            mylist.Add(new Customer() { customer_id = 3, customer_name = "GEF", salary = 6000 });

            return View(mylist);
        }


        public ActionResult show()
        {
            return View();
        }

    }
}
