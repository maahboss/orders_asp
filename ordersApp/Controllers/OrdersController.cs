using ordersApp.Models;
using ordersApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ordersApp.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            var orders = new List<Order>
            {
                new Order {Name = "Clothes"},
                new Order {Name = "Cars"}
            };

            return View(orders);


        }

        // GET: Orders/Random
        public ActionResult Random()
        {
            var order = new Order() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Id = 1 , Name = "customer 1"},
                new Customer {Id = 2 , Name = "customer 2"}
            };

            var viewModel = new RandomOrderViewModel
            {
                Order = order,
                Customers = customers
            };

            return View(viewModel);
        }


        //[Route("orders/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseYear(int year,int month)
        //{
        //    return Content(year +"/" + month);
        //}





    }
}