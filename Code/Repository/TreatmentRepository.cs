/***********************************************************************
 * Module:  TreatmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.TreatmentRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.Treatment;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using Repository.Csv.Converter;
using System.Linq;

namespace Repository
{
   public class TreatmentRepository : ITreatmentRepository
   {
        private readonly CSVStream<Treatment> _stream = new CSVStream<Treatment>("C:\\health-clinic\\health-clinic\\Code\\treatmentRepo", new TreatmentCSVConverter("|"));
        private readonly LongSequencer _sequencer = new LongSequencer();
        private TreatmentRepository()
        {
            InitializeId();
        }
        private static TreatmentRepository instance = null;
        public static TreatmentRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TreatmentRepository();
                }
                return instance;
            }
        }

        private long GetMaxId(List<Treatment> treatments)
        {
            //            return dAndRs.OrderBy(d => d.Id).First().Id;
            return treatments.Count() == 0 ? default : treatments.Max(trt => trt.Id);
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Treatment treatment)
        {
            var treatments = _stream.ReadAll().ToList();
            var treatmentToRemove = treatments.SingleOrDefault(ent => ent.Id.CompareTo(treatment.Id) == 0);
            if (treatmentToRemove != null)
            {
                treatments.Remove(treatmentToRemove);
                _stream.SaveAll(treatments);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var treatments = _stream.ReadAll().ToList();
            var treatmentToRemove = treatments.SingleOrDefault(ent => ent.Id.CompareTo(id) == 0);
            if (treatmentToRemove != null)
            {
                treatments.Remove(treatmentToRemove);
                _stream.SaveAll(treatments);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Treatment Edit(Treatment obj)
        {
            var treatments = _stream.ReadAll().ToList();
            treatments[treatments.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(treatments);
            return obj;
        }

        public List<Treatment> GetAll()
        {
            return _stream.ReadAll();
        }

        public Treatment GetTreatment(long id)
        {
            List<Treatment> treatments = _stream.ReadAll();
            return FindById(treatments, id);
        }

        private Treatment FindById(List<Treatment> treatments, long id)
        {
            foreach (Treatment treatment in treatments)
            {
                if (treatment.Id == id)
                {
                    return treatment;
                }
            }
            return null;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Treatment Save(Treatment obj)
        {
            obj.SetId(_sequencer.GenerateId());
            _stream.AppendToFile(obj);
            return obj;
        }

        protected void InitializeId() => _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
    }

}
