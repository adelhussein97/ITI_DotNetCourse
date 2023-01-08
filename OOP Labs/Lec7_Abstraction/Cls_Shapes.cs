using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7_Abstraction
{
    public abstract class Cls_Shapes
    {
        public double Dimension { get; set; }

        public Cls_Shapes(double _dim)
        {
            Dimension = _dim;
        }
        public abstract double CalcArea();
        
    }
}
