using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODEV2MUSTAFALİKAGANKUCUK.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Models.Employee> SelectAllEmployees()
        {
            return EmployeeList.SelectEmployeeList();
        }

        public Models.Employee SelectEmployeeById(int id)
        {
            return EmployeeList.SelectEmployeeList().Find(x => x.EmployeeID == id);
        }

        public void InsertEmployee(Models.Employee emp)
        {
            EmployeeList.InsertEmployeeList(emp);
        }

        public void UpdateEmployee(Models.Employee emp)
        {
            EmployeeList.UpdateEmployeeList(emp);
        }

        public void DeleteEmployee(int id)
        {
            EmployeeList.DeleteEmployeeList(id);
        }

    }
}