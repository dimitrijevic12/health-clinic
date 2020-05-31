/***********************************************************************
 * Module:  IEquipInvetoryController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IEquipInvetoryController
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Controller
{
   public interface IEquipInvetoryController : IController<InventoryEquip>
   {
      Boolean MoveInventory(Model.Rooms.Room roomFrom, Model.Rooms.Room roomTo, Model.Rooms.InventoryEquip inventory, int ammount);
      void AddAmmount(Model.Rooms.InventoryEquip inventory, int ammount);
      List<InventoryEquip> GetInventory(Model.Rooms.Room room);
   }
}