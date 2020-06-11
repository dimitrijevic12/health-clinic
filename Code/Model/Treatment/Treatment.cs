/***********************************************************************
 * Module:  Treatment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.Treatment
 ***********************************************************************/

using System;

namespace Model.Treatment
{
   public class Treatment
   {  
      /// <pdGenerated>default getter</pdGenerated>
     
      public Prescription prescription;
      public ScheduledSurgery scheduledSurgery;
      public DiagnosisAndReview diagnosisAndReview;
      public ReferralToHospitalTreatment referralToHospitalTreatment;
      public Model.SystemUsers.Doctor doctor;
   
      private DateTime FromDate;
      private DateTime EndDate;
      private int Id;
   
   }
}