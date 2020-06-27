/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.Rooms;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class RenovationRepository : IRenovationRepository
   {
        private readonly ICSVStream<Renovation> _stream = new CSVStream<Renovation>("../../Resources/Data/renovations.csv", new RenovationCSVConverter(","));
        private readonly iSequencer<long> _sequencer = new LongSequencer();

        private String _path = "../../Resources/Data/renovations.csv";
        private static RenovationRepository instance;

        public static RenovationRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RenovationRepository();
                }
                return instance;
            }
        }


        private RenovationRepository()
        {
        }

        public RenovationRepository(string path, CSVStream<Renovation> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<Renovation> renos)
        {
            return renos.Count() == 0 ? 0 : renos.Max(apt => apt.Id);
        }
        public Renovation GetRenovation(Renovation renovation)
        {
            throw new NotImplementedException();
        }

        public Renovation Save(Renovation obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Renovation Edit(Renovation obj)
        {
            var appointments = _stream.ReadAll().ToList();
            appointments[appointments.FindIndex(apt => apt.Id == obj.Id)] = obj;
            _stream.SaveAll(appointments);
            return obj;
        }

        public bool Delete(Renovation obj)
        {
            var renovations = _stream.ReadAll().ToList();
            var renovationToRemove = renovations.SingleOrDefault(reno => reno.Id == obj.Id);
            if (renovationToRemove != null)
            {
                renovations.Remove(renovationToRemove);
                _stream.SaveAll(renovations);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Renovation> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }


    }
}