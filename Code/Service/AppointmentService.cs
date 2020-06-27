/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

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
        public Repository.IAppointmentRepository iAppointmentRepository;
        private readonly IService<Doctor> _doctorService;
        private readonly IService<Patient> _patientService;
        private readonly IService<ExamOperationRoom> _roomService;

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

        

        public AppointmentService(IAppointmentRepository repository, IService<Doctor> doctorService, IService<Patient> patientService, IService<ExamOperationRoom>roomService)
        {
            iAppointmentRepository = repository;
            _doctorService = doctorService;
            _patientService = patientService;
            _roomService = roomService;

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
            List<Appointment> appointments = iAppointmentRepository.GetAll();
            List<Appointment> trazeni = new List<Appointment>();

            foreach (Appointment a in appointments)
            {
                if (a.RoomId.Equals(room.Id))
                {
                    trazeni.Add(a);
                }
            }


            return trazeni;
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
            var doctor = _doctorService.Create(obj.Doctor);
            var patient = _patientService.Create(obj.Patient);
            var room = _roomService.Create(obj.ExamOperationRoom);
            var appointment = iAppointmentRepository.Save(obj);
            appointment.Doctor = doctor;
            appointment.Patient = patient;
            appointment.ExamOperationRoom = room;
            return appointment;
        }

        public Appointment Edit(Appointment obj)
        {
            _doctorService.Edit(obj.Doctor);
            _patientService.Edit(obj.Patient);
            _roomService.Edit(obj.ExamOperationRoom);
            iAppointmentRepository.Edit(obj);
            return obj;
        }

        public bool Delete(Appointment obj)
        {
            _doctorService.Delete(obj.Doctor);
            _patientService.Delete(obj.Patient);
            _roomService.Delete(obj.ExamOperationRoom);
            iAppointmentRepository.Delete(obj);
            return true;
        }

        public List<Appointment> GetAll()
        {
            //var doctors = _doctorService.GetAll();
            //var patients = _patientService.GetAll();
            //var rooms = _roomService.GetAll();
            var appointments = iAppointmentRepository.GetAll();
            //BindAllForAppointments(appointments, doctors, patients, rooms);
            return appointments;
        }

        private void BindAllForAppointments(List<Appointment> appointments, List<Doctor> doctors, List<Patient> patients, List<ExamOperationRoom> rooms)
        {
            throw new NotImplementedException();
        }
    }
}