/***********************************************************************
 * Module:  DoctorDrugService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.DoctorDrugService
 ***********************************************************************/

using System;

namespace Service
{
   public abstract class DoctorDrugService : DecoratedDrugService
   {
      public abstract Boolean ValidateDrugs(Model.Rooms.Drug drug);
   
   }
}