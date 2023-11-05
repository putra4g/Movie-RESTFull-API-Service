using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public ActionResult<List<Movie>> GetDetailMovie(int id)
        {
            var movie = _service.GetMovieById(id);
            return Ok(movie);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            return Ok(Movie);
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
