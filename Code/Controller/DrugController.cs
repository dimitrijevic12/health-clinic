/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public class DrugController : IDrugController
   {
      public Service.DrugService drugService;

        public Drug Create(Drug obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Drug obj)
        {
            throw new NotImplementedException();
        }

        public Drug Edit(Drug obj)
        {
            throw new NotImplementedException();
        }

        public Drug GetAll()
        {
            throw new NotImplementedException();
        }

        public bool ValidateDrugs(Drug drug)
        {
            throw new NotImplementedException();
        }
    }
}