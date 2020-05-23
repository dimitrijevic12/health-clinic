/***********************************************************************
 * Module:  IRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRepository<T>
   {
      T Save(T obj);
      T Edit(T obj);
      Boolean Delete(T obj);
      T[] GetAll();
      Boolean OpenFile(String path);
      Boolean CloseFile(String path);
   }
}