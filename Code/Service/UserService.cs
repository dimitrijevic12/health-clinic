/***********************************************************************
 * Module:  UserService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using System;

namespace Service
{
   public class UserService : IUserService
   {
      public Repository.UserRepository userRepository;
   
   }
}