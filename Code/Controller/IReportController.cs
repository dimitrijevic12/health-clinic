/***********************************************************************
 * Module:  IReportController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Interface Controller.IReportController
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Controller
{
   public interface IReportController
   {
      List<Appointment> GenerateReportForDoctor(Model.SystemUsers.Doctor doctor, DateTime from, DateTime to);
      List<Room> GenereteReportForRooms(DateTime from, DateTime to);
      List<Drug> GenerateReportForDrugs(DateTime from, DateTime to);
   }
}