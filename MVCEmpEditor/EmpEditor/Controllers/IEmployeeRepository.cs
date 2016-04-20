using EmpEditor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpEditor.Controllers
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        void DeleteEmployee(int id);
        Employee GetEmployeeById(int id);
        void AddEmployee(EmpModel employee);
        void UpdateEmployee(Employee employee);
    }
}