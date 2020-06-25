/***********************************************************************
 * Module:  ReferralToHospitalTreatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.ReferralToHospitalTreatment
 ***********************************************************************/

using Model.Rooms;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Model.Treatment
{
   public class ReferralToHospitalTreatment
   {
        private List<Drug> drugs;

        /// <pdGenerated>default getter</pdGenerated>
       
   
      private DateTime startDate;
      private DateTime endDate;
      private String causeForHospTreatment;

        public ReferralToHospitalTreatment()
        { 
        }

        public ReferralToHospitalTreatment(DateTime startDate, DateTime endDate, string causeForHospTreatment)
        {
            StartDate = startDate;
            EndDate = endDate;
            CauseForHospTreatment = causeForHospTreatment;
        }

        public ReferralToHospitalTreatment(DateTime startDate, DateTime endDate, string causeForHospTreatment, List<Drug> drugs)
        {
            Drugs = drugs;
            StartDate = startDate;
            EndDate = endDate;
            CauseForHospTreatment = causeForHospTreatment;
        }

        public List<Drug> Drugs { get => drugs; set => drugs = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public string CauseForHospTreatment { get => causeForHospTreatment; set => causeForHospTreatment = value; }
    }
}