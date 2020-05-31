/***********************************************************************
 * Module:  UserService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Service
{
   public class UserService : IUserService
   {
      public UserService GetInstance() { return null; }

        public RegisteredUser LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsUsernameValid(string username)
        {
            throw new NotImplementedException();
        }

        public bool IsPasswordValid(string password)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser Create(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser Edit(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public Repository.IUserRepository iUserRepository;
   
      private static UserService Instance;
   
   }
}