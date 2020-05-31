/***********************************************************************
 * Module:  UserService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using System;

namespace Controller
{
   public class UserController : IUserController
   {
      public UserController GetInstance()
   
      public Service.IUserService iUserService;
   
      private static UserController Instance;
   
   }
}