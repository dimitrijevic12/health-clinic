/***********************************************************************
 * Module:  CSVStream.cs
 * Author:  user
 * Purpose: Definition of the Class Repository.CSVStream
 ***********************************************************************/

using Repository.Csv.Converter;
using System;
using System.Collections.Generic;

namespace Repository.Csv.Stream
{
   public class CSVStream<E> : ICSVStream<E> where E : class
    {
        private readonly ICSVConverter<E> _converter;

        public void AppendToFile(E entity)
        {
            throw new NotImplementedException();
        }

        public List<E> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void SaveAll(List<E> entities)
        {
            throw new NotImplementedException();
        }
    }
}