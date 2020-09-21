using Movie.Api.Business.Interfaces;
using Movie.Api.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Movie.Api.Business
{
    public class MovieService : IMovieService
    {
        private List<MovieEntity> _moviesList;
        
        
        public MovieService()
        {
            _moviesList = new List<MovieEntity>();
            _moviesList.Add(
                new MovieEntity{ MovieId = 0, Language="ENGLISH",Location="DELHI",
                Plot= "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency",
                Poster = "https://m.mediaamazon.com / images / M / MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_QL50_.jpg",
                SoundEffects= new string[] {"RX6", "SDDS" },
                Stills = new string[] {"https://m.mediaamazon.com/images/M/MV5BNTYxOTYyMzE3NV5BMl5BanBnXkFtZTcwOTMxNDY3Mw@@._V1_UY99_CR24,0,99,99_AL_.jpg",
                "https://m.mediaamazon.com/images/M/MV5BNzAwOTk3MDg5MV5BMl5BanBnXkFtZTcwNjQxNDY3Mw@@._V1_UY99_CR29,0,99,99_AL_.jpg",
                "https://m.mediaamazon.com/images/M/MV5BMDFkYTc0MGEtZmNhMC00ZDIzLWFmNTEtODM1ZmRlYWMwMWFmXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_UX182_CR0,0,182,268_AL__QL50.jpg"},
                Title= "The Shawshank Redemption",
                imdbID= "tt0111161",
                ListingType= "NOW_SHOWING",
                ImdbRating= 9.2
                }
                ); ;
        }
        public List<MovieEntity> GetMovies()
        {
            return _moviesList;
        }
    }
}
