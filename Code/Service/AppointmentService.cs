/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using health_clinicClassDiagram;
using health_clinicClassDiagram.Service;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Service
{
    public class AppointmentService : IAppointmentService
    {
        public Repository.IAppointmentRepository _appointmentRepository = AppointmentRepository.Instance;
        private readonly IService<Doctor> _doctorService = DoctorService.Instance;
        private readonly IService<Patient> _patientService = PatientService.Instance;
        private readonly IService<ExamOperationRoom> _roomService = ExamOperationRoomService.Instance;

        private static AppointmentService instance;

        public static AppointmentService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppointmentService();
                }
                return instance;
            }
        }

        private AppointmentService()
        {
        }

        

      

        public Appointment MoveAppointment(DateTime from, DateTime to, Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfVacant(DateTime from, DateTime to)
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
            List<Appointment> appointments = _appointmentRepository.GetAll();
            List<Appointment> wantedAppointments = new List<Appointment>();

            foreach (Appointment appointment in appointments)
            {
                if (appointment.RoomId.Equals(room.Id))
                {
                    wantedAppointments.Add(appointment);
                }
            }


            return wantedAppointments;
        }

        public Treatment GenerateTreatment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Appointment ScheduleAppointmentForGuest(Appointment appointment)
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

        public List<TermDTO> GetNewTermsForDatePeriod(DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public Appointment Create(Appointment obj)
        {
            Appointment appointment = _appointmentRepository.Save(obj);
            return appointment;
        }

        public Appointment Edit(Appointment obj)
        {
            _appointmentRepository.Edit(obj);
            return obj;
        }

        public bool Delete(Appointment obj)
        {
            return _appointmentRepository.Delete(obj);
        }

        public List<Appointment> GetAll()
        {
            List<Appointment> appointments = _appointmentRepository.GetAll();
            return appointments;
        }

        private void BindAllForAppointments(List<Appointment> appointments, List<Doctor> doctors, List<Patient> patients, List<ExamOperationRoom> rooms)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastDateOfAppointmentForRoom(Room room)
        {
            var appointments = _appointmentRepository.GetAll();

            DateTime latestDate = DateTime.Now;
            latestDate = latestDate.AddDays(-1);

            foreach(Appointment appointment in appointments)
            {
                if(appointment.RoomId == room.Id && appointment.StartDate > latestDate)
                {
                    
                        latestDate = appointment.StartDate;
                    
                }
            }
            return latestDate;
        }
    }
}