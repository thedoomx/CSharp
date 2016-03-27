using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpEditor.Models;
using System.Data.Entity;

namespace EmpEditor.Controllers
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private Week08Day03Entities context = new Week08Day03Entities();

        

        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.Find(id);
        }

        public void DeleteEmployee(int id)
        {
            Employee emp = context.Employees.Find(id);
            

            if(emp != null)
            {
                context.Employees.Remove(emp);
                context.SaveChanges();
            }
        }

        public void AddEmployee(EmpModel employee)
        {
            Employee e = new Employee() { Name = employee.Name };
            context.Employees.Add(e);
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}