using Model.SystemUsers;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> master

namespace health_clinicClassDiagram.Service
{
    public class DoctorService : IService<Doctor>
    {

        private readonly IRepository<Doctor> _doctorRepository;
<<<<<<< HEAD
        
=======

>>>>>>> master
        private static DoctorService Instance;

        public MedicalRecordService GetInstance() { return null; }

        public DoctorService(IRepository<Doctor> repository)
        {
            _doctorRepository = repository;
<<<<<<< HEAD
           
=======

>>>>>>> master
        }

        public Doctor Create(Doctor obj)
        {
            var newDoctor = _doctorRepository.Save(obj);
            return newDoctor;
        }

        public bool Delete(Doctor obj)
<<<<<<< HEAD
        {         
            return _doctorRepository.Delete(obj);          
=======
        {
            return _doctorRepository.Delete(obj);
>>>>>>> master
        }

        public Doctor Edit(Doctor obj)
        {
<<<<<<< HEAD
            return _doctorRepository.Edit(obj);         
=======
            return _doctorRepository.Edit(obj);
>>>>>>> master
        }

        public List<Doctor> GetAll()
        {
            var doctors = _doctorRepository.GetAll();
            return doctors;
        }
    }
}
