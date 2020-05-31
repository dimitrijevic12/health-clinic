/***********************************************************************
 * Module:  IDrugService.cs
 * Author:  user
 * Purpose: Definition of the Interface Service.IDrugService
 ***********************************************************************/

using System;

namespace Service
{
   public interface IDrugService
   {
      List<Drug> GetAllDrugs();
   }
}