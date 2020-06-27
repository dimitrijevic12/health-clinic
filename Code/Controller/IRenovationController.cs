/***********************************************************************
 * Module:  IRenovationController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IRenovationController
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Controller
{
   public interface IRenovationController : IController<Renovation>
   {
        Model.Rooms.Renovation ChangeDates(DateTime lastDate, Model.Rooms.Renovation renovation);
        Model.Rooms.Renovation DoPainting();
        Model.Rooms.Renovation DoMerge();
        Model.Rooms.Renovation DoSplit();
        Model.Rooms.Renovation DoChangeTypeOfRoom();
    }
}