using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thp.Lession04.Models;

namespace Thp.Lession04.Controllers
{
    public class ThpCustomerController : Controller
    {
        // GET: ThpCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action: ThpCustomerDetail
        public ActionResult ThpCustomerDetail()
        {
            //tao doi tuong du lieu
            var customer = new ThpCustomer()
            {
                CustomerId = 1,
                FirstName = "Trinh Huu",
                LastName = "Phuc",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }

        //GET: ThpListCustomer
        public ActionResult ThpListCustomer()
        {
            var list = new List<ThpCustomer>()
            {
                new ThpCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Trinh Huu",
                    LastName = "Phuc",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                new ThpCustomer() 
                {
                    CustomerId = 2,
                    FirstName = "Tran Minh",
                    LastName = "Nam",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                 new ThpCustomer()
                {
                    CustomerId = 3,
                    FirstName = "Tran Minh",
                    LastName = "Nam 1",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
                  new ThpCustomer()
                {
                    CustomerId = 4,
                    FirstName = "Tran Minh",
                    LastName = "Nam 2",
                    Address = "K22CNT3",
                    YearOfBirth = 2004
                },
            };
            ViewBag.list = list;//Dua du lieu ra view bang ViewBag
            return View();
        }
    }
}