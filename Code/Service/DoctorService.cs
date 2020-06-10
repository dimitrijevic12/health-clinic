using Model.SystemUsers;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Service
{
    public class DoctorService : IService<Doctor>
    {

        private readonly IRepository<Doctor> _doctorRepository;
        
        private static DoctorService Instance;

        public MedicalRecordService GetInstance() { return null; }

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
    }
}
