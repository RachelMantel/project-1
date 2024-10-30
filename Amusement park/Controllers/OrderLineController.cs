using Amusement_park.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLineController : ControllerBase
    {

        OrderLineService orderLineService = new OrderLineService();

        // GET: api/<OrderLineController>
        [HttpGet]
        public IEnumerable<OrderLine> Get()
        {
            return orderLineService.Get();
        }

        // GET api/<OrderLineController>/5
        [HttpGet("{id}")]
        public OrderLine Get(int id)
        {
            return orderLineService.GetById(id);
        }

        // POST api/<OrderLineController>
        [HttpPost]
        public ActionResult<bool> Post(OrderLine o)
        {
            return orderLineService.Add(o);
        }
        // PUT api/<OrderLineController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(OrderLine o)
        {
            return orderLineService.Update(o);
        }

        // DELETE api/<OrderLineController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return orderLineService.Remove(id);
        }
    }
}
