using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Api.Contracts
{
    [Serializable]
    public class User
    {
        [Key]
        [JsonProperty(PropertyName ="Id")]
        public long UserId { get; set; }

        [DataType(DataType.Text), MaxLength(50)]
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        [DataType(DataType.ImageUrl), MaxLength(200)]
        [JsonProperty(PropertyName = "Image")]
        public string UserImage { get; set; }

        [DataType(DataType.EmailAddress), MaxLength(50), Required]
        [JsonProperty(PropertyName = "Email")]
        public string UserEmail { get; set; }

        [DataType(DataType.Password), MaxLength(50), Required]
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Text)]
        [JsonProperty(PropertyName = "CurrentToken")]
        public string CurrentToken { get; set; }
    }
}
