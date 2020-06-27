/***********************************************************************
 * Module:  IDrugService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IDrugService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public interface IDrugService
   {
        List<Drug> GetAllDrugs();
        List<Drug> GetUnvalidatedDrugs();
        List<Drug> GetValidatedDrugs();

        void addDrug(String naziv, int quant);

    }
}