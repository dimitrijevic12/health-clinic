/***********************************************************************
 * Module:  IEquipRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IEquipRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IEquipRepository : IRepository<Equipment>
   {
      Model.Rooms.Equipment GetEquip(int idE);
   }
}