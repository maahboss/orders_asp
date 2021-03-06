﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ordersApp.Models
{
    public class Customer
    { 
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubToNews { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}