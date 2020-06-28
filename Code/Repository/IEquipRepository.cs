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
        bool EquipExists(string name);
        Model.Rooms.Equipment GetEquip(String name);

        Equipment GetEquip(long id);
        bool EquipExists(long id);
    }
}