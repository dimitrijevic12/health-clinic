using Controller;
<<<<<<< HEAD
using health_clinicClassDiagram.Service;
=======
>>>>>>> master
using Model.SystemUsers;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> master

namespace health_clinicClassDiagram.Controller
{
    public class DoctorController : IController<Doctor>
    {
        private static DoctorController Instance;
        public DoctorController GetInstance() { return null; }

        private readonly IService<Doctor> _service;

        public DoctorController(IService<Doctor> service)
        {
            _service = service;
        }

        public Doctor Create(Doctor obj)
        {
<<<<<<< HEAD
           return _service.Create(obj);
=======
            return _service.Create(obj);
>>>>>>> master
        }

        public bool Delete(Doctor obj)
        {
            return _service.Delete(obj);
<<<<<<< HEAD
            
=======

>>>>>>> master
        }

        public Doctor Edit(Doctor obj)
        {
            return _service.Edit(obj);
<<<<<<< HEAD
            
=======

>>>>>>> master
        }

        public List<Doctor> GetAll()
        {
            var doctors = (List<Doctor>)_service.GetAll();
            return doctors;
        }
    }
}
