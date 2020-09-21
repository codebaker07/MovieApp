using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie.Api.Contracts
{

    public class User
    {
      
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string UserImage { get; set; }

        public string UserEmail { get; set; }

        public string Password { get; set; }

    
        public string CurrentToken { get; set; }
    }
}
