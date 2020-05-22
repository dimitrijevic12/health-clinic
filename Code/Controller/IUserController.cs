/***********************************************************************
 * Module:  IUserController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IUserController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IUserController : IController
   {
      Model.SystemUsers.RegisteredUser LoginUser(String username, String password);
   }
}