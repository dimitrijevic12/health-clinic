/***********************************************************************
 * Module:  IDrugController.cs
 * Author:  user
 * Purpose: Definition of the Interface Controller.IDrugController
 ***********************************************************************/

using System;

namespace Controller
{
   public interface IDrugController
   {
      List<Drug> GetAllDrugs();
   }
}