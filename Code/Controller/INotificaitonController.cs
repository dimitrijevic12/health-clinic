/***********************************************************************
 * Module:  INotificaitonController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Interface Controller.INotificaitonController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface INotificaitonController
   {
      void NotifyPatient(Model.Appointment.Notification notification);
      void NotifyDoctor(Model.Appointment.Notification notification);
   }
}