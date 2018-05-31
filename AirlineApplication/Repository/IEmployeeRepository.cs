using System.Collections.Generic;

namespace Repository
{
    interface IEmployeeRepository
    {
        bool Insert(Employee e);
        bool Update(Employee e);
        bool Delete(string employeeId);
        Employee GetEmployees(string employeeId);
        List<Employee> GetAllEmployees();
    }
}