/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using System;

namespace Service
{
   public class AppointmentService : IAppointmentService
   {
      public Repository.AppointmentRepository appointmentRepository;

        public bool CheckIfVacant(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Appointment Create(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment Edit(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Treatment GenerateTreatment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetApointmentByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetAppointmentsByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetAppointmentsByRoom(ExamOperationRoom room)
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetAppointmentsByTime(DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }

        public Appointment[] GetAppointmentsByType(TypeOfAppointment type)
        {
            throw new NotImplementedException();
        }

        public Appointment MoveAppointment(DateTime from, DateTime to, Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Appointment ScheduleAppointmentForGuest(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}