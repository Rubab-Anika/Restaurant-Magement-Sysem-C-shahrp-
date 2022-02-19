using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.Entity
{
    public class OrderCart
    {
        public int id { set; get; }
        public string FoodType { get; set; }
        public string FoodName { get; set; }
        public int  Quantity { get; set; }
        public double  price  { get; set; }
    }
}
