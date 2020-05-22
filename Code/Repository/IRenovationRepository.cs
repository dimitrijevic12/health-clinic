/***********************************************************************
 * Module:  IRenovationRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IRenovationRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRenovationRepository : IRepository
   {
      Model.Rooms.Renovation GetRenovation(Model.Rooms.Renovation renovation);
   }
}