/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using System;

namespace Controller
{
   public class AppointmentController : IAppointmentController
   {
        public AppointmentController GetInstance() { }
   
      public Service.IAppointmentService iAppointmentService;
   
      private static AppointmentController Instance;
   
   }
}