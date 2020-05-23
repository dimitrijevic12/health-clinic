/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public class DrugInventoryRepository : IDrugInvetoryRepository
   {
      private String Path;

        public bool CloseFile(string path)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs Edit(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs[] GetAll()
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs GetDrugInv(InventoryDrugs drugInv)
        {
            throw new NotImplementedException();
        }

        public bool OpenFile(string path)
        {
            throw new NotImplementedException();
        }

        public InventoryDrugs Save(InventoryDrugs obj)
        {
            throw new NotImplementedException();
        }
    }
}