using health_clinicClassDiagram.Repository.Csv.Converter;
using health_clinicClassDiagram.Repository.Sequencer;
using Model.SystemUsers;
using Repository;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.Repository
{
    public class SurgeonRepository : IRepository<Surgeon>
    {
        private static SurgeonRepository instance = null;
        private readonly CSVStream<Surgeon> stream = new CSVStream<Surgeon>("C:\\Users\\Nemanja\\Desktop\\HCI-Lekar\\Code\\resources\\data\\SurgeonRepo.csv", new SurgeonCSVConverter("|", ""));
        private readonly LongSequencer sequencer = new LongSequencer();
        private readonly ICSVStream<Doctor> _stream;
        private readonly iSequencer<long> _sequencer;

        private String _path;
        public static SurgeonRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SurgeonRepository();
                }
                return instance;
            }
        }

        private SurgeonRepository()
        {
        }
        public MedicalRecordRepository GetInstance() { return null; }

        public SurgeonRepository(string path, CSVStream<Doctor> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<Doctor> doctors)
        {
            return doctors.Count() == 0 ? 0 : doctors.Max(apt => apt.Id);
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Surgeon obj)
        {
            //            var doctors = _stream.ReadAll().ToList();
            var doctors = stream.ReadAll().ToList();
            var doctorToRemove = doctors.SingleOrDefault(acc => acc.Id == obj.Id);
            if (doctorToRemove != null)
            {
                doctors.Remove(doctorToRemove);
                //                _stream.SaveAll(doctors);
                stream.SaveAll(doctors);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Surgeon Edit(Surgeon obj)
        {
            //            var doctors = _stream.ReadAll().ToList();
            var doctors = stream.ReadAll().ToList();
            doctors[doctors.FindIndex(apt => apt.Id == obj.Id)] = obj;
            //            _stream.SaveAll(doctors);
            stream.SaveAll(doctors);
            return obj;
        }

        public List<Surgeon> GetAll()
        {
            var doctors = (List<Surgeon>)stream.ReadAll();
            return doctors;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Surgeon Save(Surgeon obj)
        {
            stream.AppendToFile(obj);
            return obj;
        }
    }
}
