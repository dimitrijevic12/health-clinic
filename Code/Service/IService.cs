/***********************************************************************
 * Module:  IService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IService
 ***********************************************************************/
using health_clinicClassDiagram.Model;
using System;

namespace Service
{
   public interface IService<T>
   {
      T Create(T obj);
      T Edit(T obj);
      Boolean Delete(T obj);
      T[] GetAll();
   }
}