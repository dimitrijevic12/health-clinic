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
   public class DecoratedDrugService //: IDrugService
   {
      private IDrugService DrugServiceReference;

        public List<Drug> GetAllDrugs()
        {
            throw new NotImplementedException();
        }

      /*  List<Drug> IDrugService.GetAllDrugs()
        {
            throw new NotImplementedException();
        }*/
    }
}