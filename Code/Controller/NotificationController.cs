/***********************************************************************
 * Module:  NotificationController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Controller.NotificationController
 ***********************************************************************/

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
   
      public Service.INotifcationService iNotifcationService;
   
      private static NotificationController Instance;
   
   }
}