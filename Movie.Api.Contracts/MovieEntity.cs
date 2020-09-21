using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Api.Contracts
{

    public class MovieEntity
    {
   
        public int MovieId { get; set; }

 
        public string Language { get; set; }

 
        public string Location { get; set; }

  
        public string Plot { get; set; }

    
        public string Poster { get; set; }
        

        public IList<string> SoundEffects { get; set; }

 
        public IList<string> Stills { get; set; }


        public string Title { get; set; }

 
        public string imdbID { get; set; }

  
        public string ListingType { get; set; }
  
        public double ImdbRating { get; set; }

        public int UserId { get; set; }
    }
}
