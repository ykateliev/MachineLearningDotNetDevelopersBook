﻿using System;
using System.IO;
using System.Linq;

namespace CSharp
{
    public class DataReader
    {
        public static Observation ObservationFactory(string data)
        {
            var commaSeparated = data.Split(',');
            var label = commaSeparated[0];
            var pixels =
                commaSeparated
                .Skip(1)
                .Select(x => Convert.ToInt32(x))
                .ToArray();

            return new Observation(label, pixels);
        }

        public static Observation[] ReadObservations(string dataPath)
        {
            var data =
                File.ReadAllLines(dataPath)
                .Skip(1)
                .Select(ObservationFactory)
                .ToArray();

            return data;
        }
    }
}
