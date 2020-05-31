/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public class DrugService : IDrugService
   {
      public DrugService GetInstance() { return null; }
        public List<Drug> GetAllDrugs()
        {
            throw new NotImplementedException();
        }

        public Repository.IDrugRepository iDrugRepository;
   
      private static DrugService Instance;
   
   }
}