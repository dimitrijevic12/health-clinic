/***********************************************************************
 * Module:  IEquipInvetoryService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IEquipInvetoryService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public interface IEquipInvetoryService : IService<InventoryEquip>
   {
      Boolean MoveInventory(Model.Rooms.Room roomFrom, Model.Rooms.Room roomTo, Model.Rooms.InventoryEquip inventory, int ammount);
      void AddAmmount(Model.Rooms.InventoryEquip inventory, int ammount);
      Model.Rooms.InventoryEquip[] GetInventory(Model.Rooms.Room room);
   }
}