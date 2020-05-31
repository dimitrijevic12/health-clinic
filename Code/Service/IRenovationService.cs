/***********************************************************************
 * Module:  IRenovationService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IRenovationService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IRenovationService : IService
   {
      Model.Rooms.Renovation ChangeDates(DateTime lastDate, Model.Rooms.Renovation renovation);
      Model.Rooms.Renovation DoPainting();
      Model.Rooms.Renovation DoMerge();
      Model.Rooms.Renovation DoSplit();
      Model.Rooms.Renovation DoChangeTypeOfRoom();
   }
}