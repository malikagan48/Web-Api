using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ODEV2MUSTAFALİKAGANKUCUK.Models;
using ODEV2MUSTAFALİKAGANKUCUK.Repository;

namespace ODEV2MUSTAFALİKAGANKUCUK.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> SelectAllEmployees();
        Employee SelectEmployeeById(int id);
        void InsertEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
    }
}