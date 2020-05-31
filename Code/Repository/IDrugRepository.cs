/***********************************************************************
 * Module:  IDrugRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IDrugRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface IDrugRepository : IRepository
   {
      Model.Rooms.Drug GetDrug(Model.Rooms.Drug drug);
   }
}