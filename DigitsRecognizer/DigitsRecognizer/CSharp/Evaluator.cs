﻿using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class Evaluator
    {
        public static double Correct(IEnumerable<Observation> validationSet, IClassifier classifier)
        {
            return validationSet
                .Select(obs => Score(obs, classifier))
                .Average();
        }

        public static double Score(Observation obs, IClassifier classifier)
        {
            if (classifier.Predict(obs.Pixels) == obs.Label)
                return 1.0;
            else
                return 0.0;
        }
    }
}
