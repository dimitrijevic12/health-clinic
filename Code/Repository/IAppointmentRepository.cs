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
        List<Appointment> GetAppointmentsByDate(DateTime startDate, DateTime endDate);
        List<Appointment> GetAppointmentsByDayAndDoctor(DateTime day, Doctor doctor);
        List<Appointment> GetAppointmentsByDayAndDoctorAndRoom(DateTime day, Doctor doctor, ExamOperationRoom room);
        List<Appointment> GetAppointmentsByDayAndDoctorAndRoomAndPatient(DateTime day, Doctor doctor, ExamOperationRoom room, Patient patient);
    }
}