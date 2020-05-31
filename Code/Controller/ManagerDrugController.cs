/***********************************************************************
 * Module:  ManagerDrugController.cs
 * Author:  user
 * Purpose: Definition of the Class Controller.ManagerDrugController
 ***********************************************************************/

using System;

namespace Controller
{
   public abstract class ManagerDrugController : DecoratedDrugController
   {
      public abstract Model.Rooms.Drug AddDrug(Model.SystemUsers.Doctor doctor, Model.Rooms.Drug drug);
      
      public abstract Model.Rooms.Drug EditDrug(Model.Rooms.Drug drug);
      
      public abstract Boolean DeleteDrug(Model.Rooms.Drug drug);
   
   }
}