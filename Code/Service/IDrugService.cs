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
   public interface IDrugService : IService<Drug>
    {
      List<Drug> GetAllDrugs();

      void addDrug(String naziv, int quant);
    }
}