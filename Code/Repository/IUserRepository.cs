/***********************************************************************
 * Module:  IUserRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IUserRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IUserRepository : IRepository
   {
      Model.SystemUsers.RegisteredUser GetRegisteredUser(String username);
   }
}