/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class SystemUsers.Doctor
 ***********************************************************************/

using System;

namespace Model.SystemUsers
{
   public class Doctor : RegisteredUser
   {
      public WorkingSchedule[] workingSchedule;

     public Doctor() { }
   
   }
}