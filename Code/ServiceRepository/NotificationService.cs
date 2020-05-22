/***********************************************************************
 * Module:  NotificationService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using System;

namespace ServiceRepository
{
   public class NotificationService
   {
      public void NotifyPatientOfNewAppointment(Model.Appointment.Appointment appointment)
      {
         // TODO: implement
      }
      
      public void NotifyPatientOfEditedAppointment(Model.Appointment.Appointment oldAppointment, Model.Appointment.Appointment newAppointment)
      {
         // TODO: implement
      }
      
      public void NotifyPatientOfCanceledAppointment(Model.Appointment.Appointment appointment)
      {
         // TODO: implement
      }
      
      public void NotifyDoctorOfNewAppointment(Model.Appointment.Appointment appointment)
      {
         // TODO: implement
      }
      
      public void NotifyDoctorOfEditedAppointment(Model.Appointment.Appointment oldAppointment, Model.Appointment.Appointment newAppointment)
      {
         // TODO: implement
      }
      
      public void NotifyDoctorOfCanceledAppointment(Model.Appointment.Appointment appointment)
      {
         // TODO: implement
      }
   
   }
}