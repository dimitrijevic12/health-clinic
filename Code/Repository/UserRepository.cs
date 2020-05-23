/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.SystemUsers;
using System;

namespace Repository
{
   public class UserRepository : IUserRepository
   {
      private String Path;

        public bool CloseFile(string path)
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

        public RegisteredUser GetRegisteredUser(string username)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser Save(RegisteredUser obj)
        {
            throw new NotImplementedException();
        }
    }
}