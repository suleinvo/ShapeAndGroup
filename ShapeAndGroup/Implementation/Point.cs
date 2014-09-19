using System.Collections.Generic;

namespace ShapeAndGroup
{
    public class Point : IPoint
    {
        public const int Dim = 2;
        public IList<double> P { get; set; }

        public Point(params double[] points)
        {
            P = points;
        }
    }
}
