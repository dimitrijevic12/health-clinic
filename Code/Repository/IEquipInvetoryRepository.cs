/***********************************************************************
 * Module:  IEquipInvetoryRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IEquipInvetoryRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IEquipInvetoryRepository : IRepository<InventoryEquip>
   {
      Model.Rooms.InventoryEquip GetEquipInv(Model.Rooms.InventoryEquip invEquip);
   }
}