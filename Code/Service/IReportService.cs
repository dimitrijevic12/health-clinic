/***********************************************************************
 * Module:  IReportService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IReportService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IReportService
   {
      List<Appointment> GenerateReportForDoctor(Model.SystemUsers.Doctor doctor, DateTime from, DateTime to);
      List<Room> GenereteReportForRooms(DateTime from, DateTime to);
      List<Drug> GenerateReportForDrugs(DateTime from, DateTime to);
   }
}