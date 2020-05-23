/***********************************************************************
 * Module:  UserService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Service
{
   public class UserService : IUserService
   {
      public Repository.UserRepository userRepository;

        public RegisteredUser Create(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser Edit(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser[] GetAll()
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordValid(string password)
        {
            throw new NotImplementedException();
        }

        public bool IsUsernameValid(string username)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}