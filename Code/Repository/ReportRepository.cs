/***********************************************************************
 * Module:  ReportRepository.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Repository.ReportRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public class ReportRepository : IRepository
   {
      public ReportRepository GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
      private static ReportRepository Instance;
   
   }
}