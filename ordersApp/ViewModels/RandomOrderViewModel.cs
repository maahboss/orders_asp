using ordersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ordersApp.ViewModels
{
    public class RandomOrderViewModel
    {
        public Order Order { get; set; }
        public List<Customer> Customers { get; set; }
    }
}