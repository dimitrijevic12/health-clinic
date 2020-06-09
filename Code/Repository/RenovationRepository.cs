/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using health_clinicClassDiagram.Repository.Sequencer;
using Model.Rooms;
using Repository.Csv.Stream;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class RenovationRepository : IRenovationRepository
   {
        private String Path;
        private static RenovationRepository Instance;
        private readonly ICSVStream<Renovation> _stream;
        private readonly iSequencer<long> _sequencer;
        public RenovationRepository GetInstance() { return null; }

        public RenovationRepository(string path, ICSVStream<Renovation> stream, iSequencer<long> sequencer)
        {
            Path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));

        }
        private long GetMaxId(List<Renovation> renovations)
        {
            return renovations.Count() == 0 ? 0 : renovations.Max(reno => reno.Id);
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