/***********************************************************************
 * Module:  IRenovationService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IRenovationService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public interface IRenovationService : IService<Renovation>
   {
      Model.Rooms.Renovation DoPainting();
      Model.Rooms.Renovation DoMerge();
      Model.Rooms.Renovation DoSplit();
      Model.Rooms.Renovation DoChangeTypeOfRoom();
   }
}