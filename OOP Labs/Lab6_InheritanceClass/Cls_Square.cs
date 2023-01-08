using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6_InheritanceClass
{
    public class Cls_Square : Cls_Shape
    {
       

        public Cls_Square(double _dim) : base(_dim)
        {

        }
        
        
        // copy Constructor for Picture Class
        public Cls_Square(Cls_Square cls):this(cls.Dimension)
        {

        }

        public double CalcArea()
        { 
            return Dimension * Dimension; 
        }
    }
}
