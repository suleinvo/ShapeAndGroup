using System.Collections.Generic;

namespace ShapeAndGroup
{
    public class ShapeGroup<T> : List<T>, IMeasurable where T : IMeasurable
    {

        public IMeasure Measure { get; set; }

        public double GetMeasure()
        {
            return Measure.GetResult(this);
        }

        public ShapeGroup(IMeasure measure)
        {
            this.Measure = measure;
        }
    }
}
