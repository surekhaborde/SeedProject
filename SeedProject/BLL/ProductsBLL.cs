using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedProject.BLL
{
    internal class ProductsBLL
    {
        public int Userid { get; set; }
        public string prod_name  { get; set; }
        public string prod_category { get; set; }
        public string description { get; set; }
        public decimal rate { get; set; }
        public decimal qnty { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }

    }
}
