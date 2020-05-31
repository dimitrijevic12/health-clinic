/***********************************************************************
 * Module:  IService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IService
   {
      Object Create(Object object);
      Object Edit(Object object);
      Boolean Delete(Object object);
      List<Object> GetAll();
   }
}