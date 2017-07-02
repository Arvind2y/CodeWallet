using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    public class EmployeeDbContextSeeder : DropCreateDatabaseIfModelChanges<EmployeeDbContext>
    {
        protected override void Seed(EmployeeDbContext context)
        {
            List<Department> lstDepartments = new List<Department> {
               new Department
            {
                Name = "IT", Location = "New York",
                Employees = new List<Employee>() {
                    new Employee { FirstName="John", LastName="Smith", Gender="Male", Salary=10000, JobTitle="Developer" },
                    new Employee { FirstName="Joe", LastName="Carlos", Gender="Male", Salary=20000, JobTitle="Sr. Developer"  },
                    new Employee { FirstName="Juan", LastName="Williams", Gender="Male", Salary=30000, JobTitle="Project Manager" },
                    new Employee { FirstName="David", LastName="Lee",  Gender="Male", Salary=410000, JobTitle="Sr. Manager"  },
                }
               },
               new Department
               {
                   Name="HR", Location="London",
                   Employees = new List<Employee>()
                   {
                    new Employee { FirstName="Michael", LastName="Brown ", Gender="Male", Salary=15000, JobTitle="Recruiter" },
                    new Employee { FirstName="Anna", LastName="Lopez", Gender="FeMale", Salary=27000, JobTitle="Sr. Recruiter" },
                    new Employee { FirstName="Salena", LastName="Gonzalez", Gender="FeMale", Salary=35000  },
                    new Employee { FirstName="Sara", LastName="Garcia", Gender="Female", Salary=10000, JobTitle="Recruiter" }
                   }
               },
               new Department
               {
                   Name="Payroll", Location="Tokyo",
                   Employees = new List<Employee>()
                   {
                    new Employee { FirstName="Marvin", LastName="Lee", Gender="Male", Salary=10000, JobTitle="Payroll Admin" },
                    new Employee { FirstName="Chong Wei", LastName="Lee", Gender="Male", Salary=35000, JobTitle="Sr. Payroll Admin" },
                    new Employee { FirstName="Mark", LastName="David", Gender="Male", Salary=45000, JobTitle="Accountent" }
                   }
               }
            };
            context.Departments.AddRange(lstDepartments);
            base.Seed(context);
        }
    }
}
