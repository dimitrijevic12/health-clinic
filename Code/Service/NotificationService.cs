/***********************************************************************
 * Module:  NotificationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using Model.Appointment;
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

        public void NotifyPatient(Notification notification)
        {
            throw new NotImplementedException();
        }

        public void NotifyDoctor(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Repository.IRepository iRepository;
   
      private static NotificationService Instance;
   
   }
}