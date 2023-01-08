using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_InheritanceClass
{
    public class Cls_Circle : Cls_Shape
    {
        public Cls_Circle(double _dim) : base(_dim)
        {
        }

        public double CalcArea()
        {
            return 3.14 * Dimension * Dimension;
        }

        
       

    }
}
