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
        public Service.IAppointmentService _service = AppointmentService.Instance;

        private static AppointmentController instance;

        public static AppointmentController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppointmentController();
                }
                return instance;
            }
        }

        private AppointmentController()
        {
        }

      

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
            return _service.GetAll();
            
        }

        public bool Delete(Appointment obj)
        {
            return _service.Delete(obj);
           
        }

        public Appointment Create(Appointment obj)
        {
            return _service.Create(obj);
            
        }

        public Appointment Edit(Appointment obj)
        {
            return _service.Edit(obj);
            
        }
        public List<Appointment> GetAppointmentsByTimeAndDoctor(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            /*return _service.GetAppointmentsByTimeAndDoctor(doctor, startDate, endDate);*/
            throw new NotImplementedException();
        }

        public List<Appointment> GetPriorityAppointments(Doctor doctor, DateTime startDate, DateTime endDate, string priority)
        {
            /*return _service.GetPriorityAppointments(doctor, startDate, endDate, priority);*/
            throw new NotImplementedException();
        }

        public DateTime GetLastDateOfAppointmentForRoom(Room room)
        {
            return _service.GetLastDateOfAppointmentForRoom(room);
        }
    }
}