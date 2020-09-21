using Movie.Api.Business.Interfaces;
using Movie.Api.Contracts;
using System;
using System.Collections.Generic;

namespace Movie.Api.Business
{
    public class UserService : IUserService
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void bookmovie(MovieEntity movie)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(long userId)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public User IsValidCredential(string userEmail, string password)
        {
            throw new NotImplementedException();
        }
    }
}