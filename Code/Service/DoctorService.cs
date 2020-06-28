using health_clinicClassDiagram.Repository;
using Model.Appointment;
using Model.SystemUsers;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Doctor Create(Doctor obj)
        {
            Doctor newDoctor = _doctorRepository.Save(obj);
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
            List<Doctor> doctors = _doctorRepository.GetAll();
            return doctors;
        }

        public Doctor ValidateLogin(string username, string password)
        {
            return GetDoctorByUsernameAndPassword(username, password);
        }

        public List<Doctor> GetAllAvailableDoctors(DateTime _startDate, DateTime _endDate)
        {
            var doctors = _doctorRepository.GetAll();
            var appointments = AppointmentRepository.Instance.GetAll();

            List<Doctor> doctorsToRemove = new List<Doctor>();

            foreach (Appointment appointment in appointments)
            {
                if (appointment.StartDate <= _startDate && appointment.EndDate >= _endDate)
                {
                    doctorsToRemove.Add(appointment.Doctor);
                }
            }

            foreach (Doctor doctor in doctorsToRemove)
            {
                var doctorToRemove = doctors.SingleOrDefault(x => x.Id == doctor.Id);
                if (doctorToRemove != null)
                    doctors.Remove(doctorToRemove);
            }

            return doctors;
        }

        public Doctor GetDoctorByUsernameAndPassword(string username, string password)
        {
            foreach (Doctor doctor in GetAll())
            {
                if (doctor.Username.Equals(username) && doctor.Password.Equals(password)) return doctor;
            }
            return null;
        }

    }
}
