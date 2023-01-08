using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7_Abstraction
{
    class Pictures
    {

        public Cls_Shapes[] Shapes
        {
            set;
            get;

        }
        public Pictures(Cls_Shapes [] shape)
        {
            Shapes = shape;

        }
        double Sum = 0;
        
        

        public double GetTotalArea()
        {
            for (int i = 0; i < Shapes.Length; i++)
            {
                Sum += Shapes[i].CalcArea();
            }
            return Sum;
        }
    }
}
