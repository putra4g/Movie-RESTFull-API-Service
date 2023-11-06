using Application;
using Domain;
using Microsoft.AspNetCore.Http.HttpResults;
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
            if (movie == null)
            {
                return NotFound($"no Product with id : {id} was found");
            }
            return Ok(movie);
        }

        // POST api/<MoviesController>
        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            var Movie = _service.CreateMovie(movie);
            return Ok(Movie);
        }

        // PATCH api/<MoviesController>/5
        [HttpPatch("{id}")]
        public ActionResult<Movie> PatchMovie(int id, [FromBody] Movie movie)
        {
            var _movie = _service.GetMovieById(id);

            if (_movie == null)
            {
                return NotFound($"Movie has not found");
            }

            _movie.Title = movie.Title;
            _movie.Description = movie.Description;
            _movie.Rating = movie.Rating;
            _movie.Updated_At = movie.Updated_At;

            var Movie = _service.UpdateMovie(_movie);
            return Ok(Movie);
        }

        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public ActionResult<Movie> DeleteMovie(int id)
        {
            var movie = _service.GetMovieById(id);
            if (movie is null)
            {
                return NotFound($"Movie has not found");
            }

            _service.DeleteMovie(movie);

            return Ok("delete success");
        }

        // GET api/<MoviesController>/GetDetailMovieByName/{movieName}
        [HttpGet("GetDetailMovieByName/{movieName}")]
        public ActionResult<Movie> GetDetailMovieByName(string movieName)
        {
            var movie = _service.GetMovieByName(movieName);
            if (movie == null)
            {
                return NotFound($"no Movie with name : {movieName} was found");
            }
            return Ok(movie);
        }
    }
}
