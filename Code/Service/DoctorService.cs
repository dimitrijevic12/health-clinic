﻿using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.SystemUsers;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace health_clinicClassDiagram.Service
{
    public class DoctorService : IService<Doctor>
    {

        private readonly IRepository<Doctor> _doctorRepository = DoctorRepository.Instance;

        private static DoctorService instance;

        public static DoctorService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoctorService();
                }
                return instance;
            }
        }

        private DoctorService() { }

        public DoctorService(IRepository<Doctor> repository)
        {
            _doctorRepository = repository;

        }

        public Doctor Create(Doctor obj)
        {
            var newDoctor = _doctorRepository.Save(obj);
            return newDoctor;
        }

        public bool Delete(Doctor obj)
        {
            return _doctorRepository.Delete(obj);
        }

        public Doctor Edit(Doctor obj)
        {
            return _doctorRepository.Edit(obj);
        }

        public List<Doctor> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            return doctors;
        }

        public Doctor ValidateLogin(string username, string password)
        {
            return DoctorRepository.Instance.GetDoctorByUsernameAndPassword(username, password);
        }

        public List<Doctor> getAllAvailableDoctors(DateTime _startDate, DateTime _endDate)
        {
            var doctors = _doctorRepository.GetAll();
            var appointments = AppointmentRepository.Instance.GetAll();

            List<Doctor> doctorsToRemove = new List<Doctor>();

            foreach (Appointment a in appointments)
            {
                if (a.StartDate <= _startDate && a.EndDate >= _endDate)
                {
                    doctorsToRemove.Add(a.Doctor);
                }
            }

            foreach (Doctor d in doctorsToRemove)
            {
                var doctorToRemove = doctors.SingleOrDefault(x => x.Id == d.Id);
                if (doctorToRemove != null)
                    doctors.Remove(doctorToRemove);
            }

            return doctors;
        }

        public List<Doctor> GetAvailableDoctorWorkingSchedule(DateTime _startDate, DateTime _endDate, List<Doctor>doctors)
        {
            List<Doctor> availableDoctors = new List<Doctor>();
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            DayOfWeek day = calendar.GetDayOfWeek(_startDate);

            foreach (Doctor doctor in doctors)
            {
                foreach (WorkingSchedule workingSchedule in doctor.WorkingSchedules)
                {
                    
                }
            }
            return availableDoctors;
        }


    }
}
