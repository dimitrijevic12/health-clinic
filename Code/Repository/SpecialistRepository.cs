using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.SystemUsers;
using Repository;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_clinicClassDiagram.Repository
{
    class SpecialistRepository : IRepository<Specialist>
    {
        private static SpecialistRepository instance = null;
        private readonly CSVStream<Specialist> _stream = new CSVStream<Specialist>("../../Resources/Data/Specialists.csv", new SpecialistCSVConverter(","));
        private readonly LongSequencer _sequencer = new LongSequencer();
        public static SpecialistRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SpecialistRepository();
                }
                return instance;
            }
        }

        private SpecialistRepository()
        {
        }

        private long GetMaxId(List<Specialist> specialists)
        {
            return specialists.Count() == 0 ? 0 : specialists.Max(apt => apt.Id);
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Specialist obj)
        {
            var doctors = _stream.ReadAll().ToList();
            var doctorToRemove = doctors.SingleOrDefault(acc => acc.Id == obj.Id);
            if (doctorToRemove != null)
            {
                doctors.Remove(doctorToRemove);
                _stream.SaveAll(doctors);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Specialist Edit(Specialist obj)
        {
            var doctors = _stream.ReadAll().ToList();
            doctors[doctors.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(doctors);
            return obj;
        }

        public List<Specialist> GetAll()
        {
            var doctors = (List<Specialist>)_stream.ReadAll();
            return doctors;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Specialist Save(Specialist obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Specialist GetSpecialistById(long id)
        {
            return GetAll().Find(specialist => specialist.Id == id);
        }
    }
}
