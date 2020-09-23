using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movie.Api.Business.Interfaces;
using Movie.Api.Contracts;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private ILogger _logger;
        private IMovieService _service;
        public MovieController(ILogger<MovieController> logger, IMovieService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("/api/movies")]
        public ActionResult<List<MovieEntity>> GetMovies()
        {
            return Ok(_service.GetMovies());
        }

    }
}
