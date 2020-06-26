/***********************************************************************
 * Module:  IAppointmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IAppointmentRepository
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Repository
{
   public interface IAppointmentRepository : IRepository<Appointment>
   {
        List<Appointment> getAppointmentsByDate(DateTime startDate, DateTime endDate);
        List<Appointment> getAppointmentsByDayAndDoctor(DateTime day, Doctor doctor);
        List<Appointment> getAppointmentsByDayAndDoctorAndRoom(DateTime day, Doctor doctor, ExamOperationRoom room);
        Model.Appointment.Appointment GetAppointment(Model.Appointment.Appointment appointment);
      List<DateTime> GetDatesForAppointmentsInRoom(Model.Rooms.Room room);
      List<TermDTO> GetTermsByDoctorAndDatePeriod(DateTime dateFrom, DateTime dateTo, Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDoctor(Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo);
   }
}