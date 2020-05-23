/***********************************************************************
 * Module:  IDrugInvetoryController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IDrugInvetoryController
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public interface IDrugInvetoryController : IController<InventoryDrugs>
   {
      Boolean MoveDrugInventory(Model.Rooms.Room roomFrom, Model.Rooms.Room roomTo, Model.Rooms.InventoryDrugs inventory, int ammount);
      void AddAmmount(Model.Rooms.InventoryDrugs inventory, int ammount);
      Model.Rooms.InventoryDrugs[] GetInventory(Model.Rooms.Room room);
   }
}