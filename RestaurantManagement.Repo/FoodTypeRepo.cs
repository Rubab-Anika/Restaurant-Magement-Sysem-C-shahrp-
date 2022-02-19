using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurentManagement.Data;
using RestaurentManagement.Entity;
using System.Data;

namespace RestaurantManagement.Repo
{
    public class FoodTypeRepo
    {
        private string typeid;

        public string TypeId
        {
            get { return typeid; }
            set { this.typeid = "T-" + value; }
        }
        public List<FoodType> GetAll()
        {
            var typelist = new List<FoodType>();
            string sql = "select * from FoodType";
            var dt = DataAccess.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {

                FoodType type = ConvertTypeToEntity(dt.Rows[index]);
                typelist.Add(type);
            }
            return typelist;

        }
        public bool Save(FoodType type)
        {
            try
            {
                string query = "select * from FoodType  where typeId = '" + type.typeId + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into FoodType values ('" + type.typeId+ "','"+type.typeName+"');";
                }
                else
                {
                    query = "Update FoodType set typeName = '" +type.typeName + "' where typeId = '" + type.typeId+ "'";
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
                string query = "select * from FoodType where typeId = '" + id + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    return false;
                }

                query = "delete from FoodType where typeId = '" + id + "'";
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
        public List<String> FillTypeComBo()
        {
            var typelist = new List<String>();
            string sql = "select * from FoodType;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {

                string type = ConvertTypeToString(dt.Rows[index]);
                typelist.Add(type);
            }
            return typelist;

        }
        public FoodType ConvertTypeToEntity(DataRow row)
        {
            FoodType fd = new FoodType();
            fd.id =Convert.ToInt32( row["id"].ToString());
            fd.typeId = row["typeId"].ToString();
            fd.typeName = row["typeName"].ToString();
            return fd;

        }

        public String ConvertTypeToString(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            string tname = row["typeName"].ToString();
            return tname;
        }
        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from FoodType;");
            string value = dt.Rows[dt.Rows.Count - 1]["typeId"].ToString();//p-0003

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }
    }
}
