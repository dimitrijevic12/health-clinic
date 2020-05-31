/***********************************************************************
 * Module:  Equipment.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Equipment
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class Equipment
   {
      public static Equipment GetInstance()
      {
         // TODO: implement
         return null;
      }
   
      private Equipment Instance;
      private int Id;
      private TypeOfEquipment Type;
      private int Quantity;
      private String Description;
   
   }
}