/***********************************************************************
 * Module:  INotifcationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Interface Service.INotifcationService
 ***********************************************************************/

using System;

namespace Service
{
   public interface INotifcationService
   {
      void NotifyPatient(Model.Appointment.Notification notification);
      void NotifyDoctor(Model.Appointment.Notification notification);
   }
}