using health_clinicClassDiagram.Repository.Sequencer;
using Model.Treatment;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public sealed class PrescriptionRepository : IPrescriptionRepository
    {
        private PrescriptionRepository()
        {
        }
        private static PrescriptionRepository instance = null;
        private static PrescriptionRepository Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PrescriptionRepository();
                }
                return Instance;
            }
        }
        private String _path;
        private readonly ICSVStream<Prescription> _stream;
        private readonly iSequencer<long> _sequencer;


        private long GetMaxId(List<Prescription> prescriptions)
        {
            return prescriptions.Count() == 0 ? 0 : prescriptions.Max(apt => apt.Id);
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Prescription obj)
        {
            var prescriptions = _stream.ReadAll().ToList();
            var prescriptionToRemove = prescriptions.SingleOrDefault(acc => acc.Id == obj.Id);
            if (prescriptionToRemove != null)
            {
                prescriptions.Remove(prescriptionToRemove);
                _stream.SaveAll(prescriptions);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Prescription Edit(Prescription obj)
        {
            var prescriptions = _stream.ReadAll().ToList();
            prescriptions[prescriptions.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(prescriptions);
            return obj;
        }

        public List<Prescription> GetAll()
        {
            return _stream.ReadAll();
        }

        public Prescription GetPrescription(int id)
        {
            List<Prescription> prescriptions =  _stream.ReadAll();
            return findById(prescriptions, id);
        }

        private Prescription findById(List<Prescription> prescriptions, int id)
        {
            foreach (Prescription prescription in prescriptions)
            {
                if (prescription.Id == id)
                {
                    return prescription;
                }
            }
            return null;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Prescription Save(Prescription obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }
    }
}
