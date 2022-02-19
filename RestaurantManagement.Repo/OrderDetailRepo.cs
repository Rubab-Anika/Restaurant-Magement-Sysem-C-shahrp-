using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using RestaurentManagement.Entity;
using RestaurentManagement.Data;

namespace RestaurantManagement.Repo
{
    public class OrderDetailRepo
    {

        private string orderId;

        public string OrderId
        {
            get { return orderId; }
            set { this.orderId = "O-" + value; }
        }


        public List<OrderDetail> GetAll()
        {

            var orderlist = new List<OrderDetail>();
            string sql = "select * from OrderDetail;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                OrderDetail o = ConvertToEntity(dt.Rows[index]);
                orderlist.Add(o);
            }
            return orderlist;

        }


        public OrderDetail ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var o = new OrderDetail();
            o.id = Convert.ToInt32(row["id"].ToString());
            o.orderId = row["orderId"].ToString();
            o.tableName = row["tableName"].ToString();
            o.empId = row["empId"].ToString();
            o.date = DateTime.Parse(row["date"].ToString());
            o.totalBill = double.Parse(row["totalBill"].ToString());
            return o;
        }
        public List<OrderDetail> Search(OrderDetail ordr)
        {

            var orderlist = new List<OrderDetail>();
            string sql = "select * from OrderDetail Where OrderId = '"+ordr.orderId.ToString()+"' or tableName = '"+ordr.tableName.ToString()+"' or empId ='"+ordr.empId.ToString()+"' or date ='"+Convert.ToDateTime(ordr.date.ToString())+"'  ;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                OrderDetail o = ConvertToEntity(dt.Rows[index]);
                orderlist.Add(o);
            }
            return orderlist;

        }

        public List<OrderDetail> Search(string txt)
        {

            var orderlist = new List<OrderDetail>();
            string sql = "select * from OrderDetail Where OrderId like '" + txt + "%' or tableName like '" +txt + "%' or empId like '" +txt + "' or TotalBill like '" + txt + "%' ;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                OrderDetail o = ConvertToEntity(dt.Rows[index]);
                orderlist.Add(o);
            }
            return orderlist;

        }

        public List<OrderDetail> SearchDateToDate(string frm, string to)
        {
            var orderlist = new List<OrderDetail>();
            string sql = "select * from OrderDetail Where date between '" + frm + "' and '"+to+"' ;";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                OrderDetail o = ConvertToEntity(dt.Rows[index]);
                orderlist.Add(o);
            }
            return orderlist;
 
        }

        public List<OrderDetail> SearchByMonth(string frm, string to)
        {
            var orderlist = new List<OrderDetail>();
            string sql = "select * from OrderDetail Where date between '" + frm + "' and '" + to + "' ;";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                OrderDetail o = ConvertToEntity(dt.Rows[index]);
                orderlist.Add(o);
            }
            return orderlist;

        }

        public bool Save(OrderDetail or)
        {

            string query = "Insert into OrderDetail values ('" + or.orderId + "','" + or.tableName + "','" + or.empId + "','" + or.date + "','" + or.totalBill + "');";

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
        }


        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from OrderDetail;");
            string value = dt.Rows[dt.Rows.Count - 1]["orderId"].ToString();//p-0003

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }
    }
}
