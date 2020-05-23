/***********************************************************************
 * Module:  IAppointmentService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IAppointmentService
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Service
{
   public interface IAppointmentService : IService<Appointment>
   {
      Model.Appointment.Appointment MoveAppointment(DateTime from, DateTime to, Model.Appointment.Appointment appointment);
      Boolean CheckIfVacant(DateTime from, DateTime to);
      Model.Appointment.Appointment[] GetAppointmentsByDoctor(Model.SystemUsers.Doctor doctor);
      Model.Appointment.Appointment[] GetAppointmentsByTime(DateTime fromTime, DateTime toTime);
      Model.Appointment.Appointment[] GetAppointmentsByType(Model.Appointment.TypeOfAppointment type);
      Model.Appointment.Appointment[] GetApointmentByPatient(Model.SystemUsers.Patient patient);
      Model.Appointment.Appointment[] GetAppointmentsByRoom(Model.Rooms.ExamOperationRoom room);
      Model.Treatment.Treatment GenerateTreatment(Model.Appointment.Appointment appointment);
      Model.Appointment.Appointment ScheduleAppointmentForGuest(Model.Appointment.Appointment appointment);
   }
}