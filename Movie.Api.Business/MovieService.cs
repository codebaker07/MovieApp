using Movie.Api.Business.Interfaces;
using Movie.Api.Contracts;
using Movie.Api.Data.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Movie.Api.Business
{
    public class MovieService : IMovieService
    {
        public MovieService(IUnitOfWork unit) => _unitOfWork = unit;

        private IUnitOfWork _unitOfWork { get; }

        public IEnumerable<MovieEntity> GetMovies(string searchType) => MapMovies(_unitOfWork.Movies.GetMoviesFromTmdb(searchType));

      
        private IEnumerable<MovieEntity> MapMovies(string data)
        {
            var lstMovies = new List<MovieEntity>();
            if (string.IsNullOrWhiteSpace(data)) return lstMovies;
            var movieData = JObject.Parse(data)["results"];
            lstMovies = JsonConvert.DeserializeObject<List<MovieEntity>>(movieData.ToString());
            return lstMovies;
        }

        public IEnumerable<MovieEntity> GetMovies() => _unitOfWork.Movies.GetAll();

      

      
        private MovieEntity MapMovie(string data)
        {
            var movie = JsonConvert.DeserializeObject<MovieEntity>(data);
            return movie;
        }

      
   

    }
}
