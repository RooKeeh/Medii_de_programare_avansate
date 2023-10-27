﻿using LibraryModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Moldovan_Andrei_Lab1.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public int? CityID { get; set; }
        public City? City {  get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
