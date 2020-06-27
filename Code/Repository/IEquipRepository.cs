/***********************************************************************
 * Module:  IEquipRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IEquipRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IEquipRepository : IRepository<Equipment>
   {
        Model.Rooms.Equipment GetEquip(Model.Rooms.Equipment equipment);
        bool EquipExists(string naziv);
        Model.Rooms.Equipment GetEquip(String naziv);
        Equipment GetEquip(int id);
        bool EquipExists(int id);
    }
}