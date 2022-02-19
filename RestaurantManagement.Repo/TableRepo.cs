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
    public class TableRepo
    {
        public List<Table> GetAll()
        {

            var tablelist = new List<Table>();
            string sql = "select * from TableDetail;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Table t = ConvertToEntity(dt.Rows[index]);
                tablelist.Add(t);
            }
            return tablelist;
            

        }

   
        public bool Save(Table t)
        {
            try
            {
                string query = "select * from TableDetail where name = '" + t.name + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into TableDetail values ('" + t.name + "','" +t.numOfChair + "','" + t.status + "');";
                }
                else
                {
                    query = "Update TableDetail set numOfChair = '" + t.numOfChair + "',status= '" + t.status + "' where name = '" + t.name + "'";
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

        public bool Delete(string name)
        {
            string query = "select * from TableDetail where name = '" + name + "'";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from TableDetail where name = '" + name + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }

        public List<Table> Search(string txt)
        {
         
            var tablelist = new List<Table>();
            string sql = "select * from TableDetail where name like '"+txt+"%' or status like '"+txt+"%' ;";// or numOfChair like '"+Convert.ToInt32(txt)+"%'or status like '"+txt+"%';";
            var dt = DataAccess.GetDataTable(sql);
            
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Table t = ConvertToEntity(dt.Rows[index]);
                tablelist.Add(t);
            }
            return tablelist;


        }

        public Table ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var t = new Table();
            t.id = Convert.ToInt32(row["id"].ToString());
            t.name = row["name"].ToString();
            t.numOfChair = Convert.ToInt32(row["numOfChair"].ToString());
            t.status = row["status"].ToString();
            return t;
        }
      
    }
}
