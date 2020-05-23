/***********************************************************************
 * Module:  ITreatmentRepository.cs
 * Author:  user
 * Purpose: Definition of the Interface Repository.ITreatmentRepository
 ***********************************************************************/

using Model.Treatment;
using System;

namespace Repository
{
   public interface ITreatmentRepository : IRepository<Treatment>
   {
      Model.Treatment.Treatment GetTreatment(Model.Treatment.Treatment treatment);
   }
}