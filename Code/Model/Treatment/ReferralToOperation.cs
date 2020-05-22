/***********************************************************************
 * Module:  ReferralToOperation.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Treatment.ReferralToOperation
 ***********************************************************************/

using System;

namespace Model.Treatment
{
   public class ReferralToOperation
   {
      public Model.SystemUsers.Surgeon surgeon;
   
      private DateTime StartDate;
      private DateTime EndDate;
      private String Procedure;
      private String CauseForOperation;
   
   }
}