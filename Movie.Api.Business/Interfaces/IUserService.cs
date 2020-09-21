using Movie.Api.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Api.Business.Interfaces
{
    public interface IUserService
    {
        IList<User> GetUsers();
        void AddUser(User user);
        User GetUserById(long userId);
        User GetUserByEmail(string email);
        User IsValidCredential(string userEmail, string password);
        void bookmovie(MovieEntity movie);
    }
}
