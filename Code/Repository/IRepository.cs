/***********************************************************************
 * Module:  IRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRepository
   {
      Object Save(Object object);
      Object Edit(Object object);
      Boolean Delete(Object object);
      List<Object> GetAll();
      Boolean OpenFile(String path);
      Boolean CloseFile(String path);
   }
}