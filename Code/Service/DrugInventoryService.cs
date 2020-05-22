/***********************************************************************
 * Module:  InventoryService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.InventoryService
 ***********************************************************************/

using System;

namespace Service
{
   public class DrugInventoryService : IDrugInvetoryService
   {
      public Repository.DrugInventoryRepository drugInventoryRepository;
   
   }
}