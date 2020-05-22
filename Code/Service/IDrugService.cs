/***********************************************************************
 * Module:  IDrugService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IDrugService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IDrugService : IService
   {
      Boolean ValidateDrugs(Model.Rooms.Drug drug);
   }
}