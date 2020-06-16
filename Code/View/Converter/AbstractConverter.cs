﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace health_clinicClassDiagram.View.Converter
{
    class AbstractConverter
    {
        protected static IList<V> ConvertEntityListToViewList<E, V>(IList<E> entities, Func<E, V> convert)
            => entities
            .Select(convert)
            .ToList();

        protected static IList<E> ConvertViewListToEntityList<E, V>(IList<V> views, Func<V, E> convert)
            => views
            .Select(convert)
            .ToList();
    }
}