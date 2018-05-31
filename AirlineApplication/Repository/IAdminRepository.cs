using System.Collections.Generic;

namespace Repository
{
    interface IAdminRepository
    {
        bool Insert(Admin a);
        bool Update(Admin a);
        bool Delete(string adminId);
        Admin GetAdmins(string adminId);
        List<Admin> GetAllAdmins();
        
    }
}