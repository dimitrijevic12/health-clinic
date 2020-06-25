/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class AppointmentRepository : IAppointmentRepository
   {
        private static AppointmentRepository instance = null;
        private const string APPOINMENT_FILE = "../../Resources/Data/appointments.csv";
        private String _path = APPOINMENT_FILE;
        private readonly ICSVStream<Appointment> _stream = new CSVStream<Appointment>(APPOINMENT_FILE, new AppointmentCSVConverter(",", "dd.MM.yyyy."));
        private readonly iSequencer<long> _sequencer = new LongSequencer();

        public static AppointmentRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppointmentRepository();
                }
                return instance;
            }
        }

        private AppointmentRepository()
        {
        }

        public AppointmentRepository(string path, ICSVStream<Appointment> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<Appointment> appointments)
        {
            return appointments.Count() == 0 ? 0 : appointments.Max(apt => apt.Id);
        }

        public List<Appointment> getAppointmentsByDate(DateTime startDate, DateTime endDate)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach(Appointment appointment in GetAll())
            {
                if (appointment.StartDate >= startDate && (appointment.EndDate <= endDate))
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }

        public List<Appointment> getAppointmentsByDayAndDoctor(DateTime day, Doctor doctor)
        {
            List<Appointment> appointments = new List<Appointment>();
            DateTime endOfDay = day.AddDays(1);
            foreach (Appointment appointment in getAppointmentsByDate(day, endOfDay))
            {
                if(appointment.Doctor.Id == doctor.Id)
                {
                    appointments.Add(appointment);
                }
            }

            return appointments;
        }

        public List<Appointment> getAppointmentsByDayAndDoctorAndRoom(DateTime day, Doctor doctor, ExamOperationRoom room)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach (Appointment appointment in getAppointmentsByDayAndDoctor(day, doctor))
            {
                if (appointment.ExamOperationRoom.Id == room.Id)
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }

        public List<Appointment> getAppointmentsByDayAndDoctorAndRoomAndPatient(DateTime day, Doctor doctor, ExamOperationRoom room, Patient patient)
        {
            List<Appointment> appointments = new List<Appointment>();
            DateTime endDate = day.AddDays(1);
            foreach (Appointment appointment in getAppointmentsByDate(day, endDate))
            {
                if (appointment.Patient.Id == patient.Id || appointment.Doctor.Id == doctor.Id || appointment.ExamOperationRoom.Id == room.Id)
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }

        public Appointment GetAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public List<DateTime> GetDatesForAppointmentsInRoom(Room room)
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

        public Appointment Save(Appointment obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Appointment Edit(Appointment obj)
        {

            var appointments = _stream.ReadAll().ToList();
            appointments[appointments.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(appointments);
            return obj;

        }


        public bool Delete(Appointment obj)
        {
            var appointments = _stream.ReadAll().ToList();
            var appointmentToRemove = appointments.SingleOrDefault(acc => acc.Id == obj.Id);
            if (appointmentToRemove != null)
            {
                appointments.Remove(appointmentToRemove);
                _stream.SaveAll(appointments);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Appointment> GetAll()
        {
            return _stream.ReadAll();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }



    }
}