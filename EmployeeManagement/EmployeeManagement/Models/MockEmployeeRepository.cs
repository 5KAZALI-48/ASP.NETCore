using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                //Manually creating the data... 
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@gmail.com" },
                new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@gmail.com" },
                new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@gmail.com" },
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
