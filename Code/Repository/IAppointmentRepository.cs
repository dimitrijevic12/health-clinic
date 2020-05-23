/***********************************************************************
 * Module:  IAppointmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IAppointmentRepository
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Repository
{
   public interface IAppointmentRepository : IRepository<Appointment>
   {
      Model.Appointment.Appointment GetAppointment(Model.Appointment.Appointment appointment);
   }
}