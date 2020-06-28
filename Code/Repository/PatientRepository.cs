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
    public class PatientRepository : IPatientRepository
    {
        private static PatientRepository instance = null;
        //private readonly CSVStream<Patient> stream = new CSVStream<Patient>("../../Resources/Data/patients.csv", new PatientCSVConverter(",", "dd.MM.yyyy."));
        //private readonly LongSequencer sequencer = new LongSequencer();
        private readonly ICSVStream<Patient> _stream = new CSVStream<Patient>("../../Resources/Data/patients.csv", new PatientCSVConverter(",", "dd.MM.yyyy."));
        private readonly iSequencer<long> _sequencer = new LongSequencer();

        private String _path = "../../Resources/Data/patients.csv";
        public static PatientRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatientRepository();
                }
                return instance;
            }
        }

        private PatientRepository()
        {
        }

        public PatientRepository(string path, CSVStream<Patient> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<Patient> patients)
        {
            return patients.Count() == 0 ? 0 : patients.Max(apt => apt.Id);
        }

        public Patient Save(Patient obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Patient Edit(Patient obj)
        {
            var patients = _stream.ReadAll().ToList();
            patients[patients.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(patients);
            return obj;
        }

        public bool Delete(Patient obj)
        {
            var patients = _stream.ReadAll().ToList();
            var patientToRemove = patients.SingleOrDefault(acc => acc.Id == obj.Id);
            if (patientToRemove != null)
            {
                patients.Remove(patientToRemove);
                _stream.SaveAll(patients);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Patient> GetAll()
        {
            var patients = (List<Patient>)_stream.ReadAll();
            return patients;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientById(long id)
        {
            var patients = _stream.ReadAll().ToList();
            return patients[patients.FindIndex(apt => apt.Id == id)];

        }
    }
}
