using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeAndGroup.Measures
{
    public class Perimeter : IMeasure
    {
        public virtual double GetResult(IMeasurable a)
        {
            var shape = a as Shape2D;
            if (shape != null)
            {
                if (shape is Square)
                {
                    return shape.Heigth * 4;
                }
                if (shape is Ellipse)
                {
                    return (2 * Math.PI) * Math.Sqrt(((shape.Heigth * shape.Heigth) * (shape.Width * shape.Width))/2);
                }
                if (shape is Tryangle)
                {
                    return (shape.Heigth + shape.Width + ((Tryangle)shape).Hyppotenusa);
                }
            }
            throw new ArgumentException();
        }
    }
}
