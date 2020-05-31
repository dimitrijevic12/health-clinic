/***********************************************************************
 * Module:  IRenovationRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IRenovationRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IRenovationRepository : IRepository<Renovation>
   {
      Model.Rooms.Renovation GetRenovation(Model.Rooms.Renovation renovation);
   }
}