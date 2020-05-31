/***********************************************************************
 * Module:  RehabilitationRoom.cs
 * Author:  User
 * Purpose: Definition of the Class Rooms.RehabilitationRoom
 ***********************************************************************/

using Model.Appointment;
using System;
using System.Collections.Generic;

namespace Model.Rooms
{
   public class RehabilitationRoom : Room
   {
      public List<InventoryDrugs> inventoryDrugs;
      public List<MedicalRecord> medicalRecord;
   
      private int MaxCapacity;
      private int CurrentlyInUse;
   
   }
}