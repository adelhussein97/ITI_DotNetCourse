using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Day1_InterfaceTask
{
    class Cls_Point : IComparable<Cls_Point>,ICloneable
    {
        
        public int X { get; set; }
        public int Y { get; set; }
        public Cls_Point(int _x,int _y)
        {
            X = _x;
            Y = _y;
        }

        public Cls_Point()
        {
            X = 0;
            Y = 0;
        }
        public int CompareTo(Cls_Point p)
        {
            int res = this.X.CompareTo(p.X);

            if (res == 0) // Equal
            {
                res = this.Y.CompareTo(p.Y);
            }

            return res;
        }

        public override string ToString()
        {
            return "Point : ("+X.ToString()+","+Y.ToString()+")";
                
        }

        public object Clone()
        {
            
            return new Cls_Point(X,Y);
        }
    }

   
}
