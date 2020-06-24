using Controller;
using health_clinicClassDiagram.Service;
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Controller
{
    public class DoctorController : IController<Doctor>
    {
        private static DoctorController instance = null;

        public static DoctorController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DoctorController();
                }
                return instance;
            }
        }

        private DoctorController()
        {
        }

        public Doctor Create(Doctor obj)
        {
            return DoctorService.Instance.Create(obj);
        }

        public bool Delete(Doctor obj)
        {
            return DoctorService.Instance.Delete(obj);

        }

        public Doctor Edit(Doctor obj)
        {
            return DoctorService.Instance.Edit(obj);

        }

        public List<Doctor> GetAll()
        {
            return DoctorService.Instance.GetAll();
        }
    }
}
