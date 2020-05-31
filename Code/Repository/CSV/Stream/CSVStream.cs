/***********************************************************************
 * Module:  CSVStream.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.CSVStream
 ***********************************************************************/

using System;

namespace Repository.Csv.Stream
{
   public class CSVStream : ICSVStream
   {
      public Repository.Csv.Converter.ICSVConverter iCSVConverter;
   
   }
}