using Controller;
using health_clinicClassDiagram.Service;
using Model.SystemUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Controller
{
    class SpecialistController : IController<Specialist>
    {
        private static SpecialistController instance;

        public static SpecialistController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SpecialistController();
                }
                return instance;
            }
        }

        private SpecialistController()
        {
        }

        public Specialist Create(Specialist obj)
        {
            return SpecialistService.Instance.Create(obj);
        }

        public bool Delete(Specialist obj)
        {
            return SpecialistService.Instance.Delete(obj);

        }

        public Specialist Edit(Specialist obj)
        {
            return SpecialistService.Instance.Edit(obj);

        }

        public List<Specialist> GetAll()
        {
            return SpecialistService.Instance.GetAll();
        }
    }
}
