using Microsoft.AspNetCore.Mvc;
using RESTmovieValidation.Managers;
using RESTmovieValidation.Models;

namespace RESTmovieValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MoviesManager manager = new MoviesManager();

        // GET: api/<MoviesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return manager.GetAll();
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesController>
        [HttpPost]
        public Movie Post([FromBody] Movie value)
        {
            return manager.Add(value);
        }

        // PUT api/<MoviesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
