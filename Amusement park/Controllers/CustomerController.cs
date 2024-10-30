using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomersService customerService=new CustomersService();
        // GET: api/<Customer>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customerService.Get();
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public Customer Get(string id)
        {
            return customerService.GetById(id);
        }

        // POST api/<Customer>
        [HttpPost]
        public ActionResult<bool> Post(Customer c)
        {
           return customerService.Add(c);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(Customer c)
        {
           return customerService.Update(c);
        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
           return customerService.Remove(id);
        }
    }
}
