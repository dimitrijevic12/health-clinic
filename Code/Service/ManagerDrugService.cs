/***********************************************************************
 * Module:  ManagerDrugService.cs
 * Author:  user
 * Purpose: Definition of the Class Service.ManagerDrugService
 ***********************************************************************/

using Model.Rooms;
using Repository;
using System;

namespace Service
{
    public class ManagerDrugService : DecoratedDrugService
    {
        private DrugRepository _drugRepository = DrugRepository.Instance;
        public ManagerDrugService(IDrugService decoratedDrug) : base(decoratedDrug)
        {
        }

        public void AddDrug(String name, int quantity)
        {
            bool exists = _drugRepository.DrugExists(name);
            if (exists)
            {
                var Foundequip = _drugRepository.GetDrug(name);
                Foundequip.Quantity += quantity;
                _drugRepository.Edit(Foundequip);
            }
            else
            {
                Drug drug = new Drug(name, quantity);
                var newDrug = _drugRepository.Save(drug);
            }
        }

    }
}