/***********************************************************************
 * Module:  ITreatmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.ITreatmentRepository
 ***********************************************************************/

using System;

namespace Repository
{
   public interface ITreatmentRepository : IRepository
   {
      Model.Treatment.Treatment GetTreatment();
   }
}