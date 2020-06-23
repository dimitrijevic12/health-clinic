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
   public class EquipInventoryRepository : IEquipInvetoryRepository
   {
        private readonly ICSVStream<InventoryEquip> _stream;
        private readonly iSequencer<long> _sequencer;
        private String _path;
        private static EquipInventoryRepository Instance;
        public EquipInventoryRepository GetInstance() { return null; }

        public EquipInventoryRepository(string path, CSVStream<InventoryEquip> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }

        private long GetMaxId(List<InventoryEquip> equip)
        {
            return equip.Count() == 0 ? 0 : equip.Max(equ => equ.Id);
        }

        public InventoryEquip GetEquipInv(InventoryEquip invEquip)
        {
            throw new NotImplementedException();
        }

        public InventoryEquip Save(InventoryEquip obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public InventoryEquip Edit(InventoryEquip obj)
        {
            var drugs = _stream.ReadAll().ToList();
            drugs[drugs.FindIndex(dr => dr.Id == obj.Id)] = obj;
            _stream.SaveAll(drugs);
            return obj;
        }

        public bool Delete(InventoryEquip obj)
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

        public List<InventoryEquip> GetAll()
        {

            var eq = (List<InventoryEquip>)_stream.ReadAll();
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

       
   
   }
}