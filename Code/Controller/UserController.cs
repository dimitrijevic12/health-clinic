/***********************************************************************
 * Module:  UserService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class UserController : IUserController
   {
      public UserController GetInstance() { return null; }
        public RegisteredUser LoginUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<RegisteredUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(RegisteredUser obj)
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

        public Service.IUserService iUserService;
   
      private static UserController Instance;
   
   }
}