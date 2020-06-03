/***********************************************************************
 * Module:  Appointment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Appointment.Appointment
 ***********************************************************************/

using System;

namespace Model.Appointment
{
   public class Appointment
   {
      public Model.SystemUsers.Patient patient;
      public Model.SystemUsers.Doctor doctor;
      public Model.Rooms.ExamOperationRoom examOperationRoom;

      public long Id { get; set; }

      private DateTime StartDate;
      private DateTime EndDate;
      private TypeOfAppointment Type;
   
   }
}