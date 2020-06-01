/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Model.Treatment;
using System;
using System.Collections.Generic;

namespace Service
{
   public class AppointmentService : IAppointmentService
   {
        public Repository.IAppointmentRepository iAppointmentRepository;
        private readonly IService<Doctor> _doctorService;
        private readonly IService<Patient> _patientService;
        private readonly IService<ExamOperationRoom> _roomService;

        private static AppointmentService Instance;
        public AppointmentService GetInstance() { return null; }

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
            var doctor = _doctorService.Create(obj.doctor);
            var patient = _patientService.Create(obj.patient);
            var room = _roomService.Create(obj.examOperationRoom);
            var appointment = iAppointmentRepository.Save(obj);
            appointment.doctor = doctor;
            appointment.patient = patient;
            appointment.examOperationRoom = room;
            return appointment;
        }

        public Appointment Edit(Appointment obj)
        {
            _doctorService.Edit(obj.doctor);
            _patientService.Edit(obj.patient);
            _roomService.Edit(obj.examOperationRoom);
            iAppointmentRepository.Edit(obj);
            return obj;
        }

        public bool Delete(Appointment obj)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAll()
        {
            throw new NotImplementedException();
        }

        
   
   }
}