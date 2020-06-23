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
    public class DoctorRepository : IRepository<Doctor>
    {
        private static DoctorRepository instance = null;
        private readonly CSVStream<Doctor> stream = new CSVStream<Doctor>("C:\\Users\\Nemanja\\Desktop\\HCI-Lekar\\Code\\resources\\data\\DoctorRepo.csv", new DoctorCSVConverter("|", ""));
        private readonly LongSequencer sequencer = new LongSequencer();
        private readonly ICSVStream<Doctor> _stream;
        private readonly iSequencer<long> _sequencer;

        private String _path;
        public static DoctorRepository Instance
        {
             get
            {
                if (instance == null)
                {
                    instance = new DoctorRepository();
                }
                return instance;
            }
        }

        private DoctorRepository()
        {
        }

        public DoctorRepository(string path, CSVStream<Doctor> stream, iSequencer<long> sequencer)
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

        public bool Delete(Doctor obj)
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

        public Doctor Edit(Doctor obj)
        {
            var doctors = _stream.ReadAll().ToList();
            doctors[doctors.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(doctors);
            return obj;
        }

        public List<Doctor> GetAll()
        {
            var doctors = (List<Doctor>)_stream.ReadAll();
            return doctors;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public Doctor Save(Doctor obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Doctor GetDoctorById(long id)
        {
            return GetAll().SingleOrDefault(doctor => doctor.Id == id);
        }
    }
}
