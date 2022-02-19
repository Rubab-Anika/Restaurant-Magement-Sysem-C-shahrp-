using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.Entity
{
    public class FoodItem
    {
        public int id { get; set; }
        public string foodid { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double price { get; set;}
    }
}
