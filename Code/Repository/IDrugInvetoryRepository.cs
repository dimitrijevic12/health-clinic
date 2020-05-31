/***********************************************************************
 * Module:  IDrugInvetoryRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IDrugInvetoryRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IDrugInvetoryRepository : IRepository<InventoryDrugs>
   {
      Model.Rooms.InventoryDrugs GetDrugInv(Model.Rooms.InventoryDrugs drugInv);
   }
}