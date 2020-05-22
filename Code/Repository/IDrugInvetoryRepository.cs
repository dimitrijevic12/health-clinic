/***********************************************************************
 * Module:  IDrugInvetoryRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IDrugInvetoryRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IDrugInvetoryRepository : IRepository
   {
      Model.Rooms.InventoryDrugs GetDrugInv(Model.Rooms.InventoryDrugs drugInv);
   }
}