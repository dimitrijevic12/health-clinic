/***********************************************************************
 * Module:  RehabilitationRoom.cs
 * Author:  User
 * Purpose: Definition of the Class Rooms.RehabilitationRoom
 ***********************************************************************/

using Model.Appointment;
using System;

namespace Model.Rooms
{
   public class RehabilitationRoom : Room
   {
      public InventoryDrugs[] inventoryDrugs;
      public MedicalRecord[] medicalRecord;
   
      private int MaxCapacity;
      private int CurrentlyInUse;
   
   }
}