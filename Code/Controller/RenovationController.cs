/***********************************************************************
 * Module:  RenovationController.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Controller.RenovationController
 ***********************************************************************/

using System;

namespace Controller
{
   public class RenovationController : IRenovationController
   {
      public RenovationController GetInstance()
   
      public Service.IRenovationService iRenovationService;
   
      private static RenovationController Instance;
   
   }
}