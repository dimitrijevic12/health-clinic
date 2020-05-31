/***********************************************************************
 * Module:  DoctorDrugController.cs
 * Author:  user
 * Purpose: Definition of the Class Controller.DoctorDrugController
 ***********************************************************************/

using System;

namespace Controller
{
   public abstract class DoctorDrugController : DecoratedDrugController
   {
      public abstract Boolean ValidateDrugs(Model.Rooms.Drug drug);
   
   }
}