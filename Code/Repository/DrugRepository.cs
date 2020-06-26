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
   public class DrugRepository : IDrugRepository
   {
        private static DrugRepository instance = null;
        private readonly CSVStream<Drug> _stream = new CSVStream<Drug>("../../Resources/Data/Drugs.csv", new DrugCSVConverter(","));
        private readonly LongSequencer _sequencer = new LongSequencer();

        public DrugRepository GetInstance() { return null; }

        private DrugRepository()
        {
        }

        public static DrugRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DrugRepository();
                }
                return instance;
            }
        }


        private long GetMaxId(List<Drug> equip)
        {
            return equip.Count() == 0 ? 0 : equip.Max(eq => eq.Id);
        }

        public Drug Save(Drug obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Drug Edit(Drug obj)
        {
            var drugs = _stream.ReadAll().ToList();
            drugs[drugs.FindIndex(dr => dr.Id == obj.Id)] = obj;
            _stream.SaveAll(drugs);
            return obj;
        }

        public bool Delete(Drug obj)
        {
            var drugs = _stream.ReadAll().ToList();
            var drugsToRemove = drugs.SingleOrDefault(dr => dr.Id == obj.Id);
            if (drugsToRemove != null)
            {
                drugs.Remove(drugsToRemove);
                _stream.SaveAll(drugs);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Drug> GetAll()
        {
            var eq = (List<Drug>)_stream.ReadAll();
            return eq;
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool DrugExists(string naziv)
        {
            var drugs = _stream.ReadAll().ToList();
            foreach (Drug d in drugs)
            {
                if (d.Name.Equals(naziv))
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public Drug GetDrug(string naziv)
        {
            var drug = _stream.ReadAll().ToList();
            return drug[drug.FindIndex(apt => apt.Name.Equals(naziv))];
        }

        public Drug GetDrugById(long id)
        {
            var drug = _stream.ReadAll().ToList();
            return drug[drug.FindIndex(ent => ent.Id == id)];
        }

    }
}