using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurentManagement.Entity
{
    public class OrderDetail
    {
        public int id { get; set; }
        public  string orderId { get; set; }
        public string empId { get; set; }
        public string tableName { get; set; }
        public DateTime date { get; set; }
        public double totalBill { get; set; }
    }
}
