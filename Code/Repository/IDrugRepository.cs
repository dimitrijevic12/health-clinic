/***********************************************************************
 * Module:  IDrugRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.IDrugRepository
 ***********************************************************************/

using Model.Rooms;
using System;

namespace Repository
{
   public interface IDrugRepository : IRepository<Drug>
   {
      Model.Rooms.Drug GetDrug(Model.Rooms.Drug drug);
   }
}