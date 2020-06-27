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
    public abstract class DecoratedDrugService : IDrugService
    {
        protected IDrugService drugServiceReference;

        public DecoratedDrugService(IDrugService iDrugService)
        {
            this.drugServiceReference = iDrugService;
        }

        public void addDrug(string naziv, int quant)
        {
            drugServiceReference.addDrug(naziv, quant);
        }

        public List<Drug> GetAllDrugs()
        {
            return drugServiceReference.GetAllDrugs();
        }

        public List<Drug> GetUnvalidatedDrugs()
        {
            return drugServiceReference.GetUnvalidatedDrugs();
        }

        public List<Drug> GetValidatedDrugs()
        {
            return drugServiceReference.GetValidatedDrugs();
        }
    }
}