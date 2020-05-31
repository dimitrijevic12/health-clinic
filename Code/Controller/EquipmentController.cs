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
   public class EquipmentController : IEquipmentController
   {
        public EquipmentController GetInstance() { return null; }
        public List<Equipment> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Equipment Create(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Equipment Edit(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Service.IEquipmentService iEquipmentService;
   
      private static EquipmentController Instance;
   
   }
}