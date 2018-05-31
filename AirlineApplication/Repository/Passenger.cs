using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Passenger
    {
       private string passengerId;
       private string name;
       private string username;
       private string email;
       private string password;
       private string gender;
       private int age;
       private string address;
       private string question;

        public string PassengerId
        {
            get { return passengerId; }
            set { passengerId = value; }
        }

        public string Pname
       {
           get { return name;}
           set { name = value; }
       }
       public string Pusername
       {
           get { return username; }
           set { username = value; }
       }

       public string Pemail
       {
           get { return email; }
           set { email = value; }
       }

       public string Ppassword
       {
           get { return password; }
           set { password = value; }
       }


       public string Pgender
       {
           get { return gender; }
           set { gender = value; }
       }

       public int Page
       {
           get { return age; }
           set { age = value; }
       }

       

       public string Paddress
       {
           get { return address; }
           set { address = value; }
       }

       public string Pquestion
       {
           get { return question; }
           set { question = value; }
       }

       

    }
}
