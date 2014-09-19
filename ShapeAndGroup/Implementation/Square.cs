using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeAndGroup
{
    public class Square : Shape2D
    {
        public Square(IPoint startPosition, double side, IMeasure Measure)
            : base(startPosition, side, side, Measure)
        { }
    }
}
