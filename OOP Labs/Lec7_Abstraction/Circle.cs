using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7_Abstraction
{
    class Circle : Cls_Shapes
    {
        public Circle(double _dim) : base(_dim)
        {
        }

        public override double CalcArea()
        {
            return 3.14 * Dimension * Dimension;
        }
    }
}
