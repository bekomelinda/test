using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeTagger.Model;
using System.Data;
using System.Data.Entity;

namespace EmployeeTagger.Data
{
    public class EmployeeRepository
    {

        public List<Employee> GetEmployees()
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee() { Id = 1, FirstName = "Tomas", LastName = "Black", Position = "Developer" });
            employee.Add(new Employee() { Id = 2, FirstName = "Peter", LastName = "Green", Position = "Developer" });
            employee.Add(new Employee() { Id = 3, FirstName = "John", LastName = "White", Position = "Developer" });
            return employee;
        }
    }
}
