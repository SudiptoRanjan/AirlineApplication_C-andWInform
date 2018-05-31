using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public bool Insert(Employee e)
        {
            try
            {
                string query = "INSERT into Employee VALUES ('" + e.EmployeeID + "', '" + e.Name + "', '" +
                               e.Username + "','" + e.Email + "', '" + e.Password + "', '" + e.Gender +
                               "', " + e.Age + ", '" + e.Address + "','"+e.Question+"')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Update(Employee e)
        {
            try
            {
                string query = "UPDATE Employee SET Name = '" + e.Name + "', Username = '" + e.Username 
                                + "', Email = '" + e.Email + "', Password = '" + e.Password +
                               "', Gender = '" + e.Gender + "', Age = " + e.Age +  ", Address = '"
                               + e.Address + "', Question = '" + e.Question + "' WHERE EmployeeId = '" + e.EmployeeID + "'";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Delete(string employeeId)
        {
            try
            {
                string query = "DELETE From Employee WHERE EmployeeId = '" + employeeId + "' ";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);

                dcc.CloseConnection();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public Employee GetEmployees(string employeeId)
        {
            string query = "SELECT * from Employee WHERE EmployeeId = '" + employeeId + "'";
            Employee em = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                em = new Employee();
                em.EmployeeID = sdr["EmployeeId"].ToString();
                em.Username = sdr["Username"].ToString();
                em.Name = sdr["Name"].ToString();
                em.Email = sdr["Email"].ToString();
                em.Gender = Convert.ToString(sdr["Gender"]);
                em.Address = sdr["Address"].ToString();
                
                em.Age = Convert.ToInt32(sdr["Age"]);
                em.Question = sdr["Question"].ToString();
                em.Password = sdr["Password"].ToString();
                
            }
            dcc.CloseConnection();
            return em;

        }

        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT * from Employee";
            List<Employee> emList = new List<Employee>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Employee em = new Employee();
                em.EmployeeID = sdr["EmployeeId"].ToString();
                em.Username = sdr["Username"].ToString();
                em.Name = sdr["Name"].ToString();
                em.Email = sdr["Email"].ToString();
                em.Gender = Convert.ToString(sdr["Gender"]);
                em.Address = sdr["Address"].ToString();
                
                em.Age = Convert.ToInt32(sdr["Age"]);
                em.Question = sdr["Question"].ToString();
                em.Password = sdr["Password"].ToString();
                
                emList.Add(em);

            }
            dcc.CloseConnection();
            return emList;
        }
    }
}