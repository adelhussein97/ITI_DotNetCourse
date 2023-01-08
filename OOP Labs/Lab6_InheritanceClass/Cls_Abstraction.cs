using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_InheritanceClass
{
    public class Cls_Shape1
    {
        public double Dimension { get; set; }

        public Cls_Shape1(double _dim)
        {
            Dimension = _dim;
        }

        public abstract double CalcArea()
        {
            return 0;
        }
    }

    public class Cls_Circle : Cls_Shape1
    {
        public Cls_Circle(double _dim) : base(_dim)
        {
        }

        public override double CalcArea()
        {
            return 3.14 * Dimension * Dimension;
        }




    }
    
}
