/***********************************************************************
 * Module:  IRoomRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IRoomRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IRoomRepository : IRepository
   {
      Model.Rooms.Room GetRoom(int id);
   }
}