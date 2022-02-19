using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using RestaurentManagement.Data;
using RestaurentManagement.Entity;

namespace RestaurantManagement.Repo
{
    public class OrderCartRepo
    {
        public List<String> FillTableComBo()
        {
            var tablenamelist = new List<String>();
            string sql = "select * from TableDetail;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {

                string tname = ConvertTableNameToString(dt.Rows[index]);
                tablenamelist.Add(tname);
            }
            return tablenamelist;

        }

        public String ConvertTableNameToString(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            string tname = row["name"].ToString();
            return tname;
        }

        public List<String> FillFoodNameComBo(string type)
        {
            var tablenamelist = new List<String>();
            string sql = "select * from FoodItem where type='" + type + "';";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {

                string fname = ConvertFoodNameToString(dt.Rows[index]);
                tablenamelist.Add(fname);
            }
            return tablenamelist;

        }

        public String ConvertFoodNameToString(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            string fname = row["name"].ToString();
            return fname;
        }


        public string GetPrice(string name)
        {
            string price;
            string sql = "select price from FoodItem where name='" + name + "';";
            var dt = DataAccess.GetDataTable(sql);
            price = dt.Rows[0][0].ToString();
            return price;

        }

        
    }
}
