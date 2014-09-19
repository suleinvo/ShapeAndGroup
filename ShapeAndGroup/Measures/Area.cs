using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeAndGroup.Measures
{
    public class Area : IMeasure
    {
        public virtual double GetResult(IMeasurable a)
        {
            var shape = a as Shape2D;
            if (shape != null)
            {
                if (shape is Square)
                {
                    return shape.Heigth * shape.Heigth;
                }
                if (shape is Ellipse)
                {
                    return shape.Heigth * shape.Width * Math.PI;
                }
                if (shape is Tryangle)
                {
                    return (shape.Heigth * shape.Width) / 2;
                }
            }
            throw new ArgumentException();
        }
    }
}
