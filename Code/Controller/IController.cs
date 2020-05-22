/***********************************************************************
 * Module:  IController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IController
   {
      Object GetAll();
      Boolean Delete(Object object);
      Object Create(Object object);
      Object Edit(Object object);
   }
}