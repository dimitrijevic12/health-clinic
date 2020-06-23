/***********************************************************************
 * Module:  InventoryR.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.InventoryR
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class InventoryDrugs
   {
      public RehabilitationRoom rehabilitationRoom;
      public Drug drug;
      private long id;
      private int Quantity;

      public long Id { get { return id; } set { id = value; } }

    }
}