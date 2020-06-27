/***********************************************************************
 * Module:  IAppointmentService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IAppointmentService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Service
{
   public interface IAppointmentService : IService<Appointment>
   {
      List<Appointment> GetAppointmentsByRoom(Model.Rooms.ExamOperationRoom room);
      List<Appointment> GetAppointmentsByTimeAndRoom(ExamOperationRoom room, DateTime startDate, DateTime endDate);
      List<Appointment> GetAppointmentsByTimeAndDoctor(Doctor doctor, DateTime startDate, DateTime endDate);
      List<Appointment> GetPriorityAppointments(Doctor doctor, DateTime startDate, DateTime endDate, string priority);
   }
}