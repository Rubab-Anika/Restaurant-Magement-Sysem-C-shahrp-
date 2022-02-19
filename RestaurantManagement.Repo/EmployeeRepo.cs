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
      public class EmployeeRepo
    {
          private string empid;
          private UserRepo uRepo = new UserRepo();
          public string EmpID
          {
              get { return empid; }
              set { this.empid = "E-" + value; }
          }


        public List<Employee> GetAll()
        {

            var employeelist = new List<Employee>();
            string sql = "select * from Employee;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Employee emp = ConvertToEntity(dt.Rows[index]);
                employeelist.Add(emp);
            }
            return employeelist;


        }


        public bool Save(Employee e)//,string status)
        {
            try
            {
                string query = "select * from Employee where empid = '" + e.empid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    
                    query = "Insert into Employee values ('" + e.empid + "','" + e.name + "','" + e.address + "','" + e.phonenum + "','" + e.sal.ToString() + "');";
                   // UserRepo uRepo = new UserRepo();
                    //uRepo.Save(e.empid, e.name,status);
                }
                else
                {
                    query = "Update Employee set name= '" + e.name + "',address= '" + e.address + "',phonenum= '" + e.phonenum + "',sal='" + e.sal + "' where empid = '" + e.empid + "'";
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
            string query = "select * from Employee where empid = '" + id + "'";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from Employee where empid = '" + id + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
            {
                uRepo.Delete(id);
                return true; 
            }
            else
                return false;
        }

        public List<Employee> Search(string txt)
        {

            var employeelist = new List<Employee>();
            string sql = "select * from Employee where empid like '" + txt + "%' or name like '" + txt + "%' or address like '" + txt + "%'or phonenum like '" + txt + "%' ;";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Employee e = ConvertToEntity(dt.Rows[index]);
                employeelist.Add(e);
            }
            return employeelist;
        }


        public Employee UserDetail(string id)
        {
            string sql = "select * from Employee where empid ='" + id + "';";
            var dt = DataAccess.GetDataTable(sql);
            Employee emp = ConvertToEntity(dt.Rows[0]);
            return emp;
        }

        public int AutoIDValue()
        {
            var dt = DataAccess.GetDataTable("select * from Employee;");
            string value = dt.Rows[dt.Rows.Count - 1]["empid"].ToString();//p-0003

            string[] id = value.Split('-');
            int number = Convert.ToInt32(id[1]);
            return number;
        }
 

        public Employee ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var emp = new Employee();
            emp.id = Convert.ToInt32(row["id"].ToString());
            emp.empid = row["empid"].ToString();
            emp.name = row["name"].ToString();
            emp.address = row["address"].ToString();
            emp.phonenum = row["phonenum"].ToString();
            //emp.designation= row["designation"].ToString();
            emp.sal = double.Parse(row["sal"].ToString());
            return emp;
        }
    }
}
