/***********************************************************************
 * Module:  IEquipInvetoryRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IEquipInvetoryRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IEquipInvetoryRepository : IRepository
   {
      Model.Rooms.InventoryEquip GetEquipInv(Model.Rooms.InventoryEquip invEquip);
   }
}