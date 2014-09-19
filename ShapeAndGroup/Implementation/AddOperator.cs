using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeAndGroup
{
    public class AddOperator: IOperator
    {
        public double DoAction(double a, double b)
        {
            return a + b;
        }
    }
}
