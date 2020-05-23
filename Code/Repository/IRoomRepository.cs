/***********************************************************************
 * Module:  IRoomRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IRoomRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IRoomRepository : IRepository<Room>
   {
      Model.Rooms.Room GetRoom(int id);
   }
}