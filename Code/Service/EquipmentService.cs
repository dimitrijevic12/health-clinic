/***********************************************************************
 * Module:  EquipmentService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.EquipmentService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public class EquipmentService : IEquipmentService
   {
      public Repository.EquipRepository equipRepository;

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