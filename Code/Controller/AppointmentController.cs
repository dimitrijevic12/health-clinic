/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class AppointmentController : IAppointmentController
   {
        public AppointmentController GetInstance() { return null; }
    

        public List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public Appointment MoveAppointment(DateTime from, DateTime to, Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByTime(DateTime fromTime, DateTime toTime)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByType(TypeOfAppointment type)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetApointmentByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByRoom(ExamOperationRoom room)
        {
            throw new NotImplementedException();
        }

        public Treatment GenerateTreatment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Appointment ScheduleAppointmentForGuest(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public TypeOfPriority ChoosePriority(TypeOfPriority priority)
        {
            throw new NotImplementedException();
        }

        public bool IsPatientRegistered(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<TermDTO> GetTermsByDoctorAndDatePeriod(DateTime dateFrom, DateTime dateTo, Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<TermDTO> GetNewTermsForDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment Create(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Appointment Edit(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public Service.IAppointmentService iAppointmentService;
   
      private static AppointmentController Instance;
   
   }
}