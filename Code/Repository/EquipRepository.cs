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
   public class EquipRepository : IEquipRepository
   {
        private readonly ICSVStream<Equipment> _stream;
        private readonly iSequencer<long> _sequencer;

        private String _path;
        private static EquipRepository Instance;
        public EquipRepository GetInstance() { return null; }

        public EquipRepository(string path, CSVStream<Equipment> stream, iSequencer<long> sequencer)
        {
            _path = path;
            _stream = stream;
            _sequencer = sequencer;
            _sequencer.Initialize(GetMaxId(_stream.ReadAll()));
        }
        private long GetMaxId(List<Equipment> equip)
        {
            return equip.Count() == 0 ? 0 : equip.Max(eq => eq.Id);
        }

        public Equipment GetEquip(String naz)
        {
            var equip = _stream.ReadAll().ToList();
            return equip[equip.FindIndex(apt => apt.Naziv.Equals(naz))];
        }

        public Equipment Save(Equipment obj)
        {
            _stream.AppendToFile(obj);
            return obj;
        }

        public Equipment Edit(Equipment obj)
        {
            var equip = _stream.ReadAll().ToList();
            equip[equip.FindIndex(eq => eq.Id == obj.Id)] = obj;
            _stream.SaveAll(equip);
            return obj;
        }

        public bool Delete(Equipment obj)
        {
            var equip = _stream.ReadAll().ToList();
            var equipToRemove = equip.SingleOrDefault(eq => eq.Id == obj.Id);
            if (equipToRemove != null)
            {
                equip.Remove(equipToRemove);
                _stream.SaveAll(equip);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Equipment> GetAll()
        {
            var eq = (List<Equipment>)_stream.ReadAll();
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

        public bool EquipExists(string naziv)
        {
            var equips = _stream.ReadAll().ToList();
            foreach (Equipment d in equips)
            {
                if (d.Naziv.Equals(naziv))
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public Equipment GetEquip(int id)
        {
            var equip = _stream.ReadAll().ToList();
            return equip[equip.FindIndex(apt => apt.Id == id)];
        }

        public bool EquipExists(int id)
        {
            var equips = _stream.ReadAll().ToList();
            foreach (Equipment d in equips)
            {
                if (d.Id == id)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
    }
}