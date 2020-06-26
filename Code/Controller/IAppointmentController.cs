/***********************************************************************
 * Module:  IAppointmentController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IAppointmentController
 ***********************************************************************/


using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Controller
{
   public interface IAppointmentController : IController<Appointment>
   {
      List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo);
      Model.Appointment.Appointment MoveAppointment(DateTime from, DateTime to, Model.Appointment.Appointment appointment);
      List<Appointment> GetAppointmentsByDoctor(Model.SystemUsers.Doctor doctor);
      List<Appointment> GetAppointmentsByTime(DateTime fromTime, DateTime toTime);
      List<Appointment> GetAppointmentsByType(Model.Appointment.TypeOfAppointment type);
      List<Appointment> GetApointmentByPatient(Model.SystemUsers.Patient patient);
      List<Appointment> GetAppointmentsByRoom(Model.Rooms.ExamOperationRoom room);
      List<Appointment> GetAppointmentsByTimeAndRoom(ExamOperationRoom room, DateTime startDate, DateTime endDate);
      List<Appointment> GetAppointmentsByTimeAndDoctor(Doctor doctor, DateTime startDate, DateTime endDate);
      List<Appointment> GetPriorityAppointments(Doctor doctor, DateTime startDate, DateTime endDate, String priority);
      Model.Treatment.Treatment GenerateTreatment(Model.Appointment.Appointment appointment);
      Model.Appointment.Appointment ScheduleAppointmentForGuest(Model.Appointment.Appointment appointment);
      Service.TypeOfPriority ChoosePriority(Service.TypeOfPriority priority);
      Boolean IsPatientRegistered(Model.SystemUsers.Patient patient);
      List<TermDTO> GetTermsByDoctorAndDatePeriod(DateTime dateFrom, DateTime dateTo, Model.SystemUsers.Doctor doctor);
      List<TermDTO> GetNewTermsForDoctor(Model.SystemUsers.Doctor doctor);
   }
}