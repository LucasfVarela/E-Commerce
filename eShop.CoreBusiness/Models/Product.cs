using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.CoreBusiness.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string LinkImage { get; set; }   
        public string Description { get; set; } 
    }
}
