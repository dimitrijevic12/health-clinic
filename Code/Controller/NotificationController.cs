/***********************************************************************
 * Module:  NotificationController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Controller.NotificationController
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Controller
{
   public class NotificationController : INotificaitonController
   {
      public NotificationController GetInstance()
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

        public Service.INotifcationService iNotifcationService;
   
      private static NotificationController Instance;
   
   }
}