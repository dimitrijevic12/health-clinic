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
      List<DateTime> GetDatesForAppointmentsInRoom(Model.Rooms.Room room);
      List<TermDTO> GetTermsByDoctorAndDatePeriod(DateTime dateFrom, DateTime dateTo, Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDoctor(Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo);
   }
}