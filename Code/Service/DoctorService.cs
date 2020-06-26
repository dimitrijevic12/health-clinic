using health_clinicClassDiagram.Repository;
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

        public Boolean ValidateLogin(string username, string password)
        {
            if (DoctorRepository.Instance.GetDoctorByUsernameAndPassword(username, password) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
