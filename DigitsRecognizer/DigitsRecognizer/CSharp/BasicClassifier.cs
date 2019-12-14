using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class BasicClassifier : IClassifier
    {
        private IEnumerable<Observation> data;
        private readonly IDistance distance;

        public BasicClassifier(IDistance distance)
        {
            this.distance = distance;
        }

        public string Predict(int[] pixels)
        {
            Observation currentBest = null;
            var shortest = Double.MaxValue;

            foreach (var observation in this.data)
            {
                var dist = this.distance.Between(observation.Pixels, pixels);

                if(dist < shortest)
                {
                    shortest = dist;
                    currentBest = observation;
                }
            }

            return currentBest.Label;
        }

        public void Train(IEnumerable<Observation> trainingSet)
        {
            this.data = trainingSet;
        }
    }
}
