/***********************************************************************
 * Module:  IAppointmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IAppointmentRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IAppointmentRepository : IRepository
   {
      Model.Appointment.Appointment GetAppointment(Model.Appointment.Appointment appointment);
   }
}