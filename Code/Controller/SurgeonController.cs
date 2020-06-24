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
    public class SurgeonController : IController<Surgeon>
    {
        private static SurgeonController instance;

        public static SurgeonController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SurgeonController();
                }
                return instance;
            }
        }

        private SurgeonController()
        {
        }

        public Surgeon Create(Surgeon obj)
        {
            return SurgeonService.Instance.Create(obj);
        }

        public bool Delete(Surgeon obj)
        {
            return SurgeonService.Instance.Delete(obj);

        }

        public Surgeon Edit(Surgeon obj)
        {
            return SurgeonService.Instance.Edit(obj);

        }

        public List<Surgeon> GetAll()
        {
            return SurgeonService.Instance.GetAll();
        }
    }
}
