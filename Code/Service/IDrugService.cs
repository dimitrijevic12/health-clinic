/***********************************************************************
 * Module:  IDrugService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IDrugService
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Service
{
   public interface IDrugService : IService<Drug>
   {
      Boolean ValidateDrugs(Model.Rooms.Drug drug);
   }
}