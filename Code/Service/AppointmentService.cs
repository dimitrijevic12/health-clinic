/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using health_clinicClassDiagram.Repository;
using health_clinicClassDiagram.Service;
using health_clinicClassDiagram.View.Util;
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

        public AppointmentService(IAppointmentRepository repository, IService<Doctor> doctorService, IService<Patient> patientService, IService<ExamOperationRoom> roomService)
        {
            _appointmentRepository = repository;
            _doctorService = doctorService;
            _patientService = patientService;
            _roomService = roomService;

        }

        public List<Appointment> GetAppointmentsByRoom(ExamOperationRoom room)
        {
            List<Appointment> appointments = _appointmentRepository.GetAll();
            List<Appointment> wantedAppointments = new List<Appointment>();

            foreach (Appointment a in appointments)
            {
                if (a.RoomId.Equals(room.Id))
                {
                    wantedAppointments.Add(a);
                }
            }


            return wantedAppointments;
        }

        public Appointment Create(Appointment obj)
        {
            var doctor = _doctorService.Create(obj.Doctor);
            var patient = _patientService.Create(obj.Patient);
            var room = _roomService.Create(obj.ExamOperationRoom);
            var appointment = _appointmentRepository.Save(obj);
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
            _appointmentRepository.Edit(obj);
            return obj;
        }

        public bool Delete(Appointment obj)
        {
            _doctorService.Delete(obj.Doctor);
            _patientService.Delete(obj.Patient);
            _roomService.Delete(obj.ExamOperationRoom);
            _appointmentRepository.Delete(obj);
            return true;
        }

        public List<Appointment> GetAll()
        {
            var appointments = _appointmentRepository.GetAll();
            return appointments;
        }

        public List<Appointment> GetAppointmentsByTimeAndRoom(ExamOperationRoom room, DateTime startDate, DateTime endDate)
        {
            List<Appointment> appointments = _appointmentRepository.GetAll();
            List<Appointment> wantedAppointments = new List<Appointment>();

            foreach (Appointment a in appointments)
            {
                if ((a.RoomId.Equals(room.Id)) && (a.StartDate >= startDate) && (a.EndDate <= endDate))
                {
                    wantedAppointments.Add(a);
                }
            }

            return wantedAppointments;
        }

        public List<Appointment> GetAppointmentsByTimeAndDoctor(Doctor doctor, DateTime startDate, DateTime endDate)
        {
            List<Appointment> appointments = _appointmentRepository.GetAll();
            List<Appointment> wantedAppointments = new List<Appointment>();

            foreach (Appointment a in appointments)
            {
                if ((a.Doctor.Id.Equals(doctor.Id)) && (a.StartDate >= startDate) && (a.EndDate <= endDate))
                {
                    wantedAppointments.Add(a);
                }
            }

            return wantedAppointments;
        }

        public List<Appointment> GetPriorityAppointments(Doctor doctor, DateTime startDate, DateTime endDate, string priority)
        {
            List<Appointment> appointmentsToShow = listAppointments(doctor, startDate, endDate);
            List<Doctor> doctors = DoctorRepository.Instance.GetAll();

            if (appointmentsToShow.Count == 0)
            {
                if (priority.Equals("DOKTOR"))
                {
                    while (appointmentsToShow.Count < 3)
                    {
                        endDate = endDate.AddDays(1);
                        appointmentsToShow = listAppointments(doctor, startDate, endDate);
                    }
                }
                else
                {
                    while (appointmentsToShow.Count < 3)
                    {
                        doctors.Remove(doctor);
                        doctor = doctors[0];
                        appointmentsToShow = listAppointments(doctor, startDate, endDate);
                    }
                }
            }

            return appointmentsToShow;
        }

        private List<Appointment> listAppointments(Doctor doctor, DateTime startDate, DateTime endDate)
        {

            List<ExamOperationRoom> rooms = ExamOperationRoomRepository.Instance.GetAll();

            List<Appointment> wantedAppointments = GetAppointmentsByTimeAndDoctor(doctor, startDate, endDate);

            List<Appointment> roomsInUse = new List<Appointment>();
            int i = 0;
            foreach (ExamOperationRoom r in rooms)
            {
                List<Appointment> forOneRoom = GetAppointmentsByTimeAndRoom(rooms[i], startDate, endDate);
                roomsInUse.AddRange(forOneRoom);
                i++;
            }

            List<Appointment> BlankAppointments = AppointmentGenerator.Instance.generateList(startDate);

            foreach (Appointment appoint in wantedAppointments)
            {
                BlankAppointments.RemoveAll(x => x.StartDate >= appoint.StartDate && x.EndDate <= appoint.EndDate);
            }

            List<Appointment> appointmentsToShow = new List<Appointment>();

            foreach (Appointment blank in BlankAppointments)
            {
                int flag = 0;
                for (int j = 0; j < rooms.Count; j++)
                {
                    foreach (Appointment taken in roomsInUse)
                    {
                        if (blank.StartDate >= taken.StartDate && blank.EndDate <= taken.EndDate)
                        {
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        blank.ExamOperationRoom = rooms[j];
                        appointmentsToShow.Add(blank);
                        break;
                    }
                }

                if (appointmentsToShow.Count > 3)
                {
                    break;
                }
            }

            return appointmentsToShow;
        }

    }
}