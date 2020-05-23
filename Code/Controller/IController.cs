/***********************************************************************
 * Module:  IController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IController<T>
   {
      T GetAll();
      Boolean Delete(T obj);
      T Create(T obj);
      T Edit(T obj);
   }
}