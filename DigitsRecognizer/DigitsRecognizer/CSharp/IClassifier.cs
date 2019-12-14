using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public interface IClassifier
    {
        void Train(IEnumerable<Observation> trainingSet);
        string Predict(int[] pixels);
    }
}
