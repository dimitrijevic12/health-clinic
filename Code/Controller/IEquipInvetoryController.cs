/***********************************************************************
 * Module:  IEquipInvetoryController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IEquipInvetoryController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IEquipInvetoryController : IController
   {
      Boolean MoveInventory(Model.Rooms.Room roomFrom, Model.Rooms.Room roomTo, Model.Rooms.InventoryEquip inventory, int ammount);
      void AddAmmount(Model.Rooms.InventoryEquip inventory, int ammount);
      Model.Rooms.InventoryEquip[] GetInventory(Model.Rooms.Room room);
   }
}