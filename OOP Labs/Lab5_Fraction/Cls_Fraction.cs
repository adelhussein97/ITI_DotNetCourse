using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Fraction
{

    public class Cls_Fraction
    {
        #region Properties
        public  int Numerator { get; set; }
        public  int Denominator { get; set; }
        #endregion

        
        #region Constructors
        public Cls_Fraction() : this(1, 1) { }

        public Cls_Fraction(Cls_Fraction cls)
        {
            this.Numerator= cls.Numerator;
            this.Denominator= cls.Denominator;
        }
        public Cls_Fraction(int _Numb) : this (_Numb,1)
        {
            Numerator = _Numb;
            Denominator = 1;
        }
        public Cls_Fraction(int _numerator, int _denominator)
        {
            // if denominator  is equal zero can not divide by zero
            if (_denominator == 0)
                throw new Exception("Can not divide by Zero");
            else
            {
                Numerator = _numerator;
                Denominator = _denominator;
            }

        } 
        #endregion


        // Methods Operators
        #region Operators
        // 1. Operator +
        public static Cls_Fraction operator +(Cls_Fraction c1, Cls_Fraction c2)
        {

            // If the denominator for c1 && c2 Equality true 1/3 + 4/3 = 5/3
            if (c1.Denominator == c2.Denominator)
                return new Cls_Fraction(c1.Numerator + c2.Numerator, c2.Denominator);

            // 1/3 + 5/4 = 19/12 denominator are difference
            else
                return new Cls_Fraction((c1.Numerator * c2.Denominator) + (c2.Numerator * c1.Denominator), c1.Denominator * c2.Denominator);



        }

        // 2. Operator ++
        public static Cls_Fraction operator ++(Cls_Fraction c1)
        {

            return new Cls_Fraction(c1.Numerator + c1.Denominator, c1.Denominator);

        }

        // 3. Operator ==
        public static bool operator ==(Cls_Fraction c1, Cls_Fraction c2)
        {

            // If the denominator for c1 && c2 Equality true 1/3 == 3/9 = true
            if (c1.Numerator * c2.Denominator == c2.Numerator * c1.Denominator)
                return true;

            // 1/3 + 5/4 = 19/12 denominator are difference
            else
                return false;



        }
        public static bool operator !=(Cls_Fraction c1, Cls_Fraction c2)
        {

            // If the denominator for c1 && c2 Equality true 1/3 == 3/9 = true
            return  !(c1==c2) ? true : false;
               
        } 
        #endregion


        // 4. Method Print + Two Objects
        #region Print Methods Overloading
        public void Print_Fraction(Cls_Fraction obj1, Cls_Fraction obj2, Cls_Fraction Res, string Operator)
        {
            Console.WriteLine($"The Result = ({obj1.Numerator} / {obj1.Denominator}) {Operator}" +
                $" ({obj2.Numerator} / {obj2.Denominator}) = {Res.Numerator} / {Res.Denominator}");
        }
        // Method Overloading + Three Objects

        public void Print_Fraction(Cls_Fraction obj1, Cls_Fraction obj2, Cls_Fraction obj3, Cls_Fraction Res, string Operator)
        {
            Console.WriteLine($"The Result = ({obj1.Numerator} / {obj1.Denominator}) {Operator}" +
                $" ({obj2.Numerator} / {obj2.Denominator}) {Operator}" +
                $" ({obj3.Numerator} / {obj3.Denominator}) = {Res.Numerator} / {Res.Denominator}");
        }
        // ++ Operators
        public void Print_Fraction(Cls_Fraction obj1, Cls_Fraction Res, string Operator)
        {
            Console.WriteLine($"The Result = ({obj1.Numerator} / {obj1.Denominator} ) {Operator} = {Res.Numerator} / {Res.Denominator}");
        }
        // == Operators
        public void Print_Fraction(Cls_Fraction obj1, Cls_Fraction obj2, bool Res, string Operator)
        {
            Console.WriteLine($"The Result = ({obj1.Numerator} / {obj1.Denominator}) {Operator}" +
                $" ({obj2.Numerator} / {obj2.Denominator}) = {Res}");
        } 
        #endregion



    }
}
