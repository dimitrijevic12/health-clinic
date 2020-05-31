/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class DrugController : IDrugController
   {
        public DrugController GetInstance(){ return null; }
        public List<Drug> GetAllDrugs()
        {
            throw new NotImplementedException();
        }

        public Service.IDrugService iDrugService;
   
      private static DrugController Instance;
   
   }
}