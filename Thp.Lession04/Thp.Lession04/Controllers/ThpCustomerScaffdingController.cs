using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thp.Lession04.Models;

namespace Thp.Lession04.Controllers
{
    public class ThpCustomerScaffdingController : Controller
    {
        //mockdata
        private static List<ThpCustomer> ListCustomer = new List<ThpCustomer>()
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
        // GET: ThpCustomerScaffding
        //listcustomer
        public ActionResult Index()
        {
            return View(ListCustomer);
        }
        [HttpGet]
        public  ActionResult ThpCreate()
        {
            var model = new ThpCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult ThpCreate(ThpCustomer model)
        {
            //Them moi khach hang
            ListCustomer.Add(model);

            //return View(model);
            return RedirectToAction("Index");
        }

        public ActionResult ThpEdit(int id)
        {
            var customer = ListCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}