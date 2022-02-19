using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RestaurentManagement.Data;
using RestaurentManagement.Entity;

namespace RestaurantManagement.Repo
{
    public class FoodItemRepo
    {

        private string foodid;

        public string FoodId
        {
            get { return foodid; }
            set { this.foodid = "F-" + value; }
        }
        public List<FoodItem> GetAll()
        {
            
                var fooditemlist = new List<FoodItem>();
                string sql = "select * from FoodItem;";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0 ; index < dt.Rows.Count; index++)
                { 
                    FoodItem fd = ConvertToEntity(dt.Rows[index]);
                    fooditemlist.Add(fd);
                }
                return fooditemlist;
         
        }
   
        

        public bool Save(FoodItem fd)
        {
            try
            {
                string query = "select * from FoodItem where foodid = '" + fd.foodid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into FoodItem values ('" + fd.foodid + "','" + fd.type + "','" + fd.name + "','" + fd.price.ToString()+ "');";
                }
                else
                {
                    query = "Update FoodItem set type = '" + fd.type + "',name= '" + fd.name + "',price= '" + fd.price + "' where foodid = '" +fd.foodid + "'";
                }

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
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                string query = "select * from FoodItem where foodid = '" + id + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from FoodItem where foodid = '" + id + "'";
                int count = DataAccess.ExecuteUpdateQuery(query);
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
        public bool DeleteByType(string type)
        {
            try
            {
                string query = "select * from FoodItem where type = '" + type + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from FoodItem where type = '" + type + "'";
                int count = DataAccess.ExecuteUpdateQuery(query);
                if (count != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception exception)
            {
                return false;
            }
        }
        
        public List<FoodItem> Search(string txt)
        {
            try
            {
                var foodlist = new List<FoodItem>();
                string sql = "select * from FoodItem where foodid like '" + txt + "%' or name like '" + txt + "%' or Type like '" + txt + "%' ;";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    FoodItem f = ConvertToEntity(dt.Rows[index]);
                    foodlist.Add(f);
                }
                return foodlist;
            }
             catch (Exception exception)
            {
                return null;
            }
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from FoodItem;");
            string value = dt.Rows[dt.Rows.Count - 1]["foodid"].ToString();//p-0003

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }

        public FoodItem ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var fd = new FoodItem();
            fd.id = Convert.ToInt32(row["id"].ToString());
            fd.foodid = row["foodid"].ToString();
            fd.name = row["name"].ToString();
            fd.type = row["type"].ToString();
            fd.price = double.Parse(row["price"].ToString());
            return fd;
        }
             
    }
}
