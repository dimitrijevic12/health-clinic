/***********************************************************************
 * Module:  ReportController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Controller.ReportController
 ***********************************************************************/

using System;

namespace Controller
{
   public class ReportController : IReportController
   {
      public ReportController GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      public System.Collections.ArrayList iReportService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetIReportService()
      {
         if (iReportService == null)
            iReportService = new System.Collections.ArrayList();
         return iReportService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetIReportService(System.Collections.ArrayList newIReportService)
      {
         RemoveAllIReportService();
         foreach (Service.IReportService oIReportService in newIReportService)
            AddIReportService(oIReportService);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddIReportService(Service.IReportService newIReportService)
      {
         if (newIReportService == null)
            return;
         if (this.iReportService == null)
            this.iReportService = new System.Collections.ArrayList();
         if (!this.iReportService.Contains(newIReportService))
            this.iReportService.Add(newIReportService);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveIReportService(Service.IReportService oldIReportService)
      {
         if (oldIReportService == null)
            return;
         if (this.iReportService != null)
            if (this.iReportService.Contains(oldIReportService))
               this.iReportService.Remove(oldIReportService);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllIReportService()
      {
         if (iReportService != null)
            iReportService.Clear();
      }
   
      private ReportController Instance;
   
   }
}