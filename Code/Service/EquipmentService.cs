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
   public class EquipmentService : IEquipmentService
   {
      public EquipmentService GetInstance() { return null; }

        public Equipment Create(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public Equipment Edit(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Equipment obj)
        {
            throw new NotImplementedException();
        }

        public List<Equipment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Repository.IEquipRepository iEquipRepository;
   
      private static EquipmentService Instance;
   
   }
}