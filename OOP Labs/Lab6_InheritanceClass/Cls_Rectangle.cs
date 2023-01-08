using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_InheritanceClass
{
    public class Cls_Rectangle : Cls_Shape
    {
        public Cls_Rectangle(double _dim, double _width) : base(_dim)
        {
            Width = _width;
            Dimension = _dim;
        }

        public double Width { get; set; }
      

        public Cls_Rectangle(Cls_Rectangle c) :this(c.Dimension,c.Width)
        {

        }
       
        public double CalcArea()
        {
            return Width * Dimension;
        }
    }
}
