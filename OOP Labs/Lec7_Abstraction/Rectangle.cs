using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7_Abstraction
{
    public class Rectangle : Cls_Shapes
    {
        public Rectangle(double _dim, double _width) : base(_dim)
        {
            Width = _width;
            Dimension = _dim;
        }

        public double Width { get; set; }
        public override double CalcArea()
        {
            return Width * Dimension;
        }
    }
}
