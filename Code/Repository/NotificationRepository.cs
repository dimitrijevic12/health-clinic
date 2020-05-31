/***********************************************************************
 * Module:  NotificationRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.NotificationRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public class NotificationRepository : IRepository
   {
      public NotificationRepository GetInstance() 
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
      private static NotificationRepository Instance;
   
   }
}