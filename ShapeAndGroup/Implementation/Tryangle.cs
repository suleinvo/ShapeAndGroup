using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeAndGroup
{
    public class Tryangle : Shape2D
    {
        public double Hyppotenusa
        {
            get { return Math.Sqrt(this.Heigth * this.Heigth + this.Width + this.Width); }
            private set { Hyppotenusa = value; }
        }

        public Tryangle(IPoint startPosition, double r, double h, IMeasure Measure)
            : base(startPosition, h, r, Measure)
        {
        }
    }
}
