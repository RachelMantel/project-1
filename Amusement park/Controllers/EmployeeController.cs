using Amusement_park.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeService employeeService =new EmployeeService();

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeService.Get();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(string id)
        {
            return employeeService.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public ActionResult<bool> Post(Employee e)
        {
            return employeeService.Add(e);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(Employee e)
        {
            return employeeService.Update(e);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            return employeeService.Remove(id);
        }
    }
}
