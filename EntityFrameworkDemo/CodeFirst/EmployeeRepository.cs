using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class EmployeeRepository
    {
        EmployeeDbContext context = null;
        public List<Employee> GetEmployees()
        {
            context = new EmployeeDbContext();
            return context.Employees.ToList();
        }

        public List<Department> GetDepartments()
        {
            context = new EmployeeDbContext();
            return context.Departments.Include("Employees").ToList();
        }
    }
}
