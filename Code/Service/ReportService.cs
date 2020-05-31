/***********************************************************************
 * Module:  ReportService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.ReportService
 ***********************************************************************/

using Model.Appointment;
using Model.Rooms;
using Model.SystemUsers;
using System;
using System.Collections.Generic;

namespace Service
{
   public class ReportService : IReportService
   {
      public ReportService GetInstance() { return null; }
        public List<Appointment> GenerateReportForDoctor(Doctor doctor, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public List<Room> GenereteReportForRooms(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public List<Drug> GenerateReportForDrugs(DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public Repository.IRepository iRepository;
   
      private static ReportService Instance;
   
   }
}