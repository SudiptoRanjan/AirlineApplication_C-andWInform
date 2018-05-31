using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AllUsersRepository : IAllUsers
    {
        public bool Delete(string userId)
        {
            try
            {
                string query = "DELETE From UserInfo WHERE UserId = '" + userId + "' ";
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

        public AllUsers GetUser(string userId)
        {
            string query = "SELECT * from UserInfo WHERE UserId  = '" + userId + "' or UserType Like '" + userId + "' or UserName Like '" + userId + "' ";
            AllUsers a = null;
            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                a = new AllUsers();
                a.UserId = sdr["UserId"].ToString();
                a.UserName = sdr["UserName"].ToString();
                a.UserType = Convert.ToString(sdr["UserType"]);

            }
            dcc.CloseConnection();
            return a;
        }

        public List<AllUsers> GetAllUsers()
        {
            string query = "SELECT * from UserInfo";
            List<AllUsers> userList = new List<AllUsers>();

            DatabaseConnection dcc = new DatabaseConnection();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                AllUsers a = new AllUsers();
                a.UserId = sdr["UserId"].ToString();
                a.UserName = sdr["UserName"].ToString();
                a.UserType = Convert.ToString(sdr["UserType"]);

                userList.Add(a);

            }
            dcc.CloseConnection();
            return userList;
        }

        public bool Insert(AllUsers a)
        {
            try
            {
                string query = "INSERT into UserInfo VALUES ('" + a.UserId + "', '" + a.UserType + "', '" + a.UserName + "')";
                DatabaseConnection dcc = new DatabaseConnection();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool Update(AllUsers a)
        {
            try
            {
                string query = "UPDATE UserInfo SET UserType = '" + a.UserType
                                + "', UserName = '" + a.UserName + "' WHERE UserId = '" + a.UserId + "'";
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
    }
}
