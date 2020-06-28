/***********************************************************************
 * Module:  IAppointmentService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IAppointmentService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public interface IAppointmentService : IService<Appointment>
   {
      Model.Appointment.Appointment MoveAppointment(DateTime from, DateTime to, Model.Appointment.Appointment appointment);
      Boolean CheckIfVacant(DateTime from, DateTime to);
      List<Appointment> GetAppointmentsByDoctor(Model.SystemUsers.Doctor doctor);
      List<Appointment> GetAppointmentsByTime(DateTime fromTime, DateTime toTime);
      List<Appointment> GetAppointmentsByType(Model.Appointment.TypeOfAppointment type);
      List<Appointment> GetApointmentByPatient(Model.SystemUsers.Patient patient);
      List<Appointment> GetAppointmentsByRoom(Model.Rooms.ExamOperationRoom room);
      Model.Treatment.Treatment GenerateTreatment(Model.Appointment.Appointment appointment);
      Model.Appointment.Appointment ScheduleAppointmentForGuest(Model.Appointment.Appointment appointment);
      TypeOfPriority ChoosePriority(TypeOfPriority priority);
      List<TermDTO> GetTermsByDoctorAndDatePeriod(DateTime dateFrom, DateTime dateTo, Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDoctor(Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo);

      DateTime GetLastDateOfAppointmentForRoom(Room room);
   }
}