using Amusement_park.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        OrderService orderService = new OrderService();

        // GET: api/<OrderController>
        [HttpGet]

        public IEnumerable<Order> Get()
        {
            return orderService.Get();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orderService.GetById(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> Post(Order o)
        {
            return orderService.Add(o);
        }


        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(Order o)
        {
            return orderService.Update(o);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return orderService.Remove(id);
        }
    }
}
