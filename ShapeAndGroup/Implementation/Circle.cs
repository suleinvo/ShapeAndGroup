using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeAndGroup
{
    public class Ellipse : Shape2D
    {
        public Ellipse(IPoint startPosition, double r, double h, IMeasure Measure)
            : base(startPosition, h, r, Measure)
        {
        }
    }
}
