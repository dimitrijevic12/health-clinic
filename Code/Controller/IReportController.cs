/***********************************************************************
 * Module:  IReportController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Interface Controller.IReportController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IReportController
   {
      List<Appointment> GenerateReportForDoctor(Model.SystemUsers.Doctor doctor, DateTime from, DateTime to);
      List<Room> GenereteReportForRooms(DateTime from, DateTime to);
      List<Drug> GenerateReportForDrugs(DateTime from, DateTime to);
   }
}