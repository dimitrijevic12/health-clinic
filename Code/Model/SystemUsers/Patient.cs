/***********************************************************************
 * Module:  Patient.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Patient
 ***********************************************************************/

using System;

namespace Model.SystemUsers
{
   public class Patient : RegisteredUser
   {
      private DateTime DateOfBirth;
      private Boolean GuestAccount;
   
   }
}