using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AllUsers
    {
        private string userId;
        private string userName;
        private string userType;


        public string UserId
        {
            set { userId = value; }
            get { return userId; }
        }

        public string UserName
        {
            set { userName = value; }
            get { return userName; }
        }

        public string UserType
        {
            set { userType = value; }
            get { return userType; }
        }




    }
}
