/***********************************************************************
 * Module:  IDrugInvetoryService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IDrugInvetoryService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IDrugInvetoryService : IService
   {
      Boolean MoveDrugInventory(Model.Rooms.Room roomFrom, Model.Rooms.Room roomTo, Model.Rooms.InventoryDrugs inventory, int ammount);
      void AddAmmount(Model.Rooms.InventoryDrugs inventory, int ammount);
      List<InventoryDrugs> GetInventory(Model.Rooms.Room room);
   }
}