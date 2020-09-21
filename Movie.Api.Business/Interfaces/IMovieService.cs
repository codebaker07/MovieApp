using Movie.Api.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Movie.Api.Business.Interfaces
{
    public interface IMovieService
    {
         List<MovieEntity> GetMovies();
        
       
    }
}
