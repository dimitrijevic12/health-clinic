﻿using health_clinicClassDiagram.Repository.Csv.Converter;
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
        private readonly CSVStream<Surgeon> _stream = new CSVStream<Surgeon>("../../Resources/Data/Surgeon.csv", new SurgeonCSVConverter(","));
        private readonly LongSequencer _sequencer = new LongSequencer();

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

        public Surgeon Edit(Surgeon obj)
        {
            var doctors = _stream.ReadAll().ToList();
            doctors[doctors.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(doctors);
            return obj;
        }

        public List<Surgeon> GetAll()
        {
            var doctors = (List<Surgeon>)_stream.ReadAll();
            return doctors;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Surgeon Save(Surgeon obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Surgeon GetSurgeonById(long id)
        {
            return GetAll().SingleOrDefault(surgeon => surgeon.Id == id);
        }
    }
}
