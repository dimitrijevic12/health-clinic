/***********************************************************************
 * Module:  NotificationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using System;

namespace Service
{
   public class NotificationService : INotifcationService
   {
      public NotificationService GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public Repository.IRepository iRepository;
   
      private static NotificationService Instance;
   
   }
}