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
    public class UserRepo
    {
       
        public User UserValid(string userID, string userPass)
        {
           
            string sql = "select * from UserDetail where userid='"+ userID +"'and pass='"+userPass+"';";
            var dt = DataAccess.GetDataTable(sql);

            if (dt.Rows.Count == 1)
            {
                User usr = new User();
                usr.id = Convert.ToInt32(dt.Rows[0][0].ToString());
                usr.userid = dt.Rows[0][1].ToString();
                usr.pass = dt.Rows[0][2].ToString();
                usr.designation = dt.Rows[0][3].ToString();
                return usr;
            }
            else return null;
        }
        public void Save(string id, string name,string designation)
        {
            if (designation == "Manager")
            {
                string query = "Insert into UserDetail values ('" + id + "','" + name + "','Manager');";
                DataAccess.ExecuteUpdateQuery(query);
            }
            else
            {
                string query = "Insert into UserDetail values ('" + id + "','" + name + "','Employee');";
                DataAccess.ExecuteUpdateQuery(query);
            }
        }
        public void Delete(string id)
        {
            string query = "Delete from UserDetail Where userId ='" + id + "'; ";
                DataAccess.ExecuteUpdateQuery(query);
        }
        public bool UpdatePass(string newpass,string userid)
        {
            string query = "update userDetail set pass='" + newpass + "'where userid='" + userid + "';";
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
        
       
    }
}
