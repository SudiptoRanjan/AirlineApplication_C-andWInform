using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IAllUsers
    {
        bool Insert(AllUsers a);
        bool Update(AllUsers a);
        bool Delete(string userId);
        AllUsers GetUser(string userId);
        List<AllUsers> GetAllUsers();
    }
}
