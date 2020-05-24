/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public class EquipmentController : IEquipmentController
   {
      public Service.EquipmentService equipmentService;

        public Equipment Create(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Equipment Edit(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Equipment[] GetAll()
        {
            throw new NotImplementedException();
        }
    }
}