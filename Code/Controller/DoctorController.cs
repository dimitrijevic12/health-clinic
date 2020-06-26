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
        private static DoctorController instance;

        private readonly IService<Doctor> _service = DoctorService.Instance;

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

        private DoctorController() { }

        public DoctorController(IService<Doctor> service)
        {
            _service = service;
        }

        public Doctor Create(Doctor obj)
        {
            return _service.Create(obj);
        }

        public bool Delete(Doctor obj)
        {
            return _service.Delete(obj);

        }

        public Doctor Edit(Doctor obj)
        {
            return _service.Edit(obj);

        }

        public List<Doctor> GetAll()
        {
            var doctors = (List<Doctor>)_service.GetAll();
            return doctors;
        }

        public Boolean ValidateLogin(string username, string password)
        {
            return DoctorService.Instance.ValidateLogin(username, password);
        }

    }
}
