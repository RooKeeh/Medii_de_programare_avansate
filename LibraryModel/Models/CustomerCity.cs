using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moldovan_Andrei_Lab1.Models
{
    public class CustomerCity
    {
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public int CityID { get; set; }
        public string? CityName { get; set; }
    }
}
