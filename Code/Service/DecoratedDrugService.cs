/***********************************************************************
 * Module:  DecoratedDrugService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.DecoratedDrugService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DecoratedDrugService : IDrugService
   {
        private IDrugService DrugServiceReference;

        public void addDrug(string naziv, int quant)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetAllDrugs()
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetUnvalidatedDrugs()
        {
            throw new NotImplementedException();
        }

        public List<Drug> GetValidatedDrugs()
        {
            throw new NotImplementedException();
        }
    }
}