/***********************************************************************
 * Module:  Renovation.cs
 * Author:  Nemanja
 * Purpose: Definition of the Class Rooms.Renovation
 ***********************************************************************/

using System;

namespace Model.Rooms
{
   public class Renovation
   {
      public Room[] room;
   
      private DateTime StartDate;
      private DateTime EndDate;
      private TypeOfRenovation TypeOfRenovation;

        public DateTime startDate  // property
        {
            get { return StartDate; }   // get method
            set { StartDate = value; }  // set method
        }
        public DateTime endDate  // property
        {
            get { return EndDate; }   // get method
            set { EndDate = value; }  // set method
        }

        public int Id { get; internal set; }
    }
}