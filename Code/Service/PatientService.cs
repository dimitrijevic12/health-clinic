using health_clinicClassDiagram.Repository;
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
    public class PatientService : IService<Patient>
    {
        private readonly IRepository<Patient> _patientRepository = PatientRepository.Instance;

        private static PatientService instance;

        public static PatientService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatientService();
                }
                return instance;
            }
        }

        private PatientService()
        {

        }

        public PatientService(IRepository<Patient> repository)
        {
            _patientRepository = repository;

        }

        public Patient Create(Patient obj)
        {
            var newPatient = _patientRepository.Save(obj);
            return newPatient;
        }

        public bool Delete(Patient obj)
        {
            return _patientRepository.Delete(obj);
        }

        public Patient Edit(Patient obj)
        {
            return _patientRepository.Edit(obj);
        }

        public List<Patient> GetAll()
        {
            var patients = _patientRepository.GetAll();
            return patients;
        }
    }
}
