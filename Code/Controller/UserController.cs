/***********************************************************************
 * Module:  UserService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Controller
{
   public class UserController : IUserController
   {
      public Service.UserService userService;

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

        public RegisteredUser LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}