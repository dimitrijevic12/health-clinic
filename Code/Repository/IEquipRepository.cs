/***********************************************************************
 * Module:  IEquipRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IEquipRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IEquipRepository : IRepository
   {
      Model.Rooms.Equipment GetEquip(Model.Rooms.Equipment equipment);
   }
}