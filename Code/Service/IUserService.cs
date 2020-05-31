/***********************************************************************
 * Module:  IUserService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IUserService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IUserService : IService
   {
      Model.SystemUsers.RegisteredUser LoginUser(String username, String password);
      Boolean IsUsernameValid(String username);
      Boolean IsPasswordValid(String password);
   }
}