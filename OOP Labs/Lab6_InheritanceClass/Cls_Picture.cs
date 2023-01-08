using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_InheritanceClass
{
    
    public class Cls_Picture
    {
        #region Composition Relation
        Cls_Square square;
        public Cls_Square Square_Property
        {
            set
            {
                square = new Cls_Square(value);
            }
            get
            {
                return new Cls_Square(square);
            }
        }
        #endregion

        

        #region Aggregation Relation 
       
        public Cls_Rectangle RectProperty { get; set; }
        #endregion

        #region Association Relation
        Cls_Circle circle = new Cls_Circle(6.5);
        public double Get_AreaCircle() // use it when calling function
        {
            return circle.CalcArea();
        }
        #endregion

        public double Get_TotalArea(Cls_Square squa,Cls_Rectangle rect)
        {
            return squa.CalcArea() + rect.CalcArea();
        }
    }
}
