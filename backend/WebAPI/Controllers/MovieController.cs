using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult getAllMovies()
        {
            try
            {
                var result = _movieService.ListAll();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult getOneMovie(int id)
        {
            try
            {
                var result = _movieService.getOneById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult addMovie(Movie movie)
        {
            try
            {
                var result = _movieService.Add(movie);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult deleteMovie(Movie movie)
        {
            try
            {
                var result = _movieService.Delete(movie);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult updateMovie(Movie movie)
        {
            try
            {
                var result = _movieService.Update(movie);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet("Movies-with-Users")]
        public IActionResult getAllMoviesWithUser()
        {
            try
            {
                var result = _movieService.ListUserWithMovies();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
