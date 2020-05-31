/***********************************************************************
 * Module:  IReportService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IReportService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using System;
using System.Collections.Generic;

namespace Service
{
   public interface IReportService
   {
      List<Appointment> GenerateReportForDoctor(Model.SystemUsers.Doctor doctor, DateTime from, DateTime to);
      List<Room> GenereteReportForRooms(DateTime from, DateTime to);
      List<Drug> GenerateReportForDrugs(DateTime from, DateTime to);
   }
}