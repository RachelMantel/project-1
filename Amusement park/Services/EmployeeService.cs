using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class EmployeeService
    {
        static List<Employee> employees = new List<Employee> {
        new Employee
        {
            Id = "321654987",
            Name = "Chaim Levy",
            Email = "chaim@gmail.com",
            Phone = "054-555-5555",
            Role = "Project Manager",
            Seniority = 5,
            Salary = 90000,
            WorkingHours = 45,
            Status = true
        }
        };


        public List<Employee> Get()
        {
            return employees;
        }

        public Employee GetById(string id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(Employee employee)
        {
            employees.Add(employee);
            return true;
        }

        public ActionResult<bool> Update(Employee employee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Id == employee.Id)
                {
                    employees[i] = employee;
                    return true;
                }
            }
            return false;

        }

        public ActionResult<bool> Remove(string id)
        {
            return employees.Remove(employees.FirstOrDefault(x => x.Id == id));
        }

    }
}
