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

        private static DoctorService instance = null;

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

        private DoctorService()
        {
        }

        public Doctor Create(Doctor obj)
        {
            return DoctorRepository.Instance.Save(obj);
        }

        public bool Delete(Doctor obj)
        {
            return DoctorRepository.Instance.Delete(obj);
        }

        public Doctor Edit(Doctor obj)
        {
            return DoctorRepository.Instance.Edit(obj);
        }

        public List<Doctor> GetAll()
        {
            return DoctorRepository.Instance.GetAll();
        }
    }
}
