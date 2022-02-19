using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.Entity
{
   public class Manager
    {
        public int id { get; set; }
        public string managerid { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phonenum { get; set; }
        public double sal { get; set; }
        //public string designation { get; set; }
    }
}
