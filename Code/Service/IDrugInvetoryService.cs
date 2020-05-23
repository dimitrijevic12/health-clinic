/***********************************************************************
 * Module:  IDrugInvetoryService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IDrugInvetoryService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public interface IDrugInvetoryService : IService<InventoryDrugs>
   {
      Boolean MoveDrugInventory(Model.Rooms.Room roomFrom, Model.Rooms.Room roomTo, Model.Rooms.InventoryDrugs inventory, int ammount);
      void AddAmmount(Model.Rooms.InventoryDrugs inventory, int ammount);
      Model.Rooms.InventoryDrugs[] GetInventory(Model.Rooms.Room room);
   }
}