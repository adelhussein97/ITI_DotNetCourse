using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7_Abstraction
{
    class Square : Cls_Shapes
    {
        public Square(double _dim) : base(_dim)
        {

        }
        // copy Constructor for Picture Class
        public Square(Square cls) : this(cls.Dimension)
        {

        }

        public override double CalcArea()
        {
            return Dimension * Dimension;
        }
    }
}
