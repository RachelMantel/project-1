using Amusement_park.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amusement_park.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {
        FacilitiesService facilitiesService = new FacilitiesService();

        // GET: api/<FacilitiesController>
        [HttpGet]
        public IEnumerable<Facilitie> Get()
        {
            return facilitiesService.Get();
        }

        // GET api/<FacilitiesController>/5
        [HttpGet("{id}")]
        public Facilitie Get(int id)
        {
            return facilitiesService.GetById(id);
        }

        // POST api/<FacilitiesController>
        [HttpPost]
        public ActionResult<bool> Post(Facilitie f)
        {
            return facilitiesService.Add(f);
        }

        // PUT api/<FacilitiesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(Facilitie f)
        {
            return facilitiesService.Update(f);
        }

        // DELETE api/<FacilitiesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return facilitiesService.Remove(id);
        }
    }
}
