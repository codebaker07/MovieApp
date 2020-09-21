using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Api.Contracts
{
    [Serializable]
    public class MovieEntity
    {
        [Key]
        [JsonProperty(PropertyName ="Id")]
        public long MovieId { get; set; }

        [DataType(DataType.Text), MaxLength(50), Required]
        [JsonProperty(PropertyName = "Language")]
        public string Language { get; set; }

        [DataType(DataType.Text), MaxLength(50)]
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        [DataType(DataType.Text), MaxLength(500)]
        [JsonProperty(PropertyName = "Plot")]
        public string Plot { get; set; }

        [DataType(DataType.ImageUrl), MaxLength(500), Required]
        [JsonProperty(PropertyName = "Poster_path")]
        public string MovieImage { get; set; }
        
        [JsonProperty(PropertyName = "SoundEffects")]
        public IList<string> SoundEffects { get; set; }

        [JsonProperty(PropertyName = "Stills")]
        public IList<string> Stills { get; set; }

        [DataType(DataType.Text), MaxLength(30)]
        [JsonProperty(PropertyName = "Title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "ImdbID")]
        public int imdbID { get; set; }

        [DataType(DataType.Text), MaxLength(30)]
        [JsonProperty(PropertyName = "ListingType")]
        public string ListingType { get; set; }
        [DataType(DataType.Text), MaxLength(30)]

        [JsonProperty(PropertyName = "ImdbRating")]
        public int ImdbRating { get; set; }

        [JsonProperty(PropertyName = "Userid")]
        public long UserId { get; set; }
    }
}
