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
        bool DrugExists(string naziv);
        Model.Rooms.Drug GetDrug(String naziv);
    }
}