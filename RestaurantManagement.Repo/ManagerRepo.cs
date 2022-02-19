using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RestaurentManagement.Entity;
using RestaurentManagement.Data;

namespace RestaurantManagement.Repo
{
    public class ManagerRepo
    {
        private string mgrId;
        private UserRepo uRepo = new UserRepo();
        public string MgrId
        {
            get { return mgrId; }
            set { this.mgrId = "M-" + value; }
        }
        public List<Manager> GetAll()
        {

            var managerlist = new List<Manager>();
            string sql = "select * from ManagerDetail;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Manager mgr = ConvertToEntity(dt.Rows[index]);
                managerlist.Add(mgr);
            }
            return managerlist;


        }

        
       public Manager ConvertToEntity(DataRow row)
        {
           
            var mgr = new Manager();
            mgr.id = Convert.ToInt32(row["id"].ToString());
            mgr.managerid= row["managerid"].ToString();
            mgr.name = row["name"].ToString();
            mgr.address = row["address"].ToString();
            mgr.phonenum=row["phonenum"].ToString();
            mgr.sal=double.Parse(row["sal"].ToString());
            return mgr;
        }
        public Manager UserDetail(string id)
        {
            string sql = "select * from ManagerDetail where managerid ='"+id+"';";
            var dt = DataAccess.GetDataTable(sql);
            Manager mgr = ConvertToEntity(dt.Rows[0]);
            return mgr;
        }

        public bool Save(Manager m)
        {
            try
            {
                string query = "select * from ManagerDetail where  managerid = '" + m.managerid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {

                    query = "Insert into ManagerDetail values ('" +m.managerid + "','" + m.name + "','" + m.address + "','" + m.phonenum + "','" + m.sal.ToString() + "');";

                }
                else
                {
                    query = "Update ManagerDetail set name= '" + m.name + "',address= '" + m.address + "',phonenum= '" + m.phonenum + "',sal='"+m.sal+"' where managerid = '" + m.managerid + "'";
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
            string query = "select * from ManagerDetail where managerid = '" + id + "'";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from ManagerDetail where managerid = '" + id + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
            {
                uRepo.Delete(id);
                return true;
            }
            else
                return false;
        }

        public List<Manager> Search(string txt)
        {

            var managerlist = new List<Manager>();
            string sql = "select * from ManagerDetail where managerid like '" + txt + "%' or name like '" + txt + "%' or address like '" + txt + "%'or phonenum like '" + txt + "%' ;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Manager e = ConvertToEntity(dt.Rows[index]);
                managerlist.Add(e);
            }
            return managerlist;
        }


        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from ManagerDetail;");
            string value = dt.Rows[dt.Rows.Count - 1]["managerid"].ToString();//p-0003

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }
    }
}
