using Lab5_Fraction;

int Counter=1 , oneValue=0;
string Operator;

Cls_Fraction c1 = new Cls_Fraction();
Cls_Fraction c2 = new Cls_Fraction();
Cls_Fraction c = new Cls_Fraction();

Cls_Fraction Res=new Cls_Fraction() ;
Cls_Fraction Res3rd=new Cls_Fraction();
try
{

    while (Counter != 0)
    {

        Console.WriteLine("Please Enter The First Fraction Numerator1");
        c1.Numerator = int.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter The First Fraction Denominator1");
        c1.Denominator = int.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter The Operator Fraction ");
        Operator = Console.ReadLine().ToString();

        

        
        switch (Operator)
        {
            case "+":
                Console.WriteLine("Please Enter The Second Fraction Numerator2");
                c2.Numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Second Fraction Denominator2");
                c2.Denominator = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter The Third Fraction Numerator2");
                c.Numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Third Fraction Denominator2");
                c.Denominator = int.Parse(Console.ReadLine());
                Cls_Fraction c3 = new Cls_Fraction(c);
                Res = c1 + c2; // two fraction
                Res3rd = c1 + c2 + c3; // third fraction
                Res.Print_Fraction(c1, c2, Res, Operator);
                Res.Print_Fraction(c1, c2, c3, Res3rd, Operator);
                break;
            case "++":
                Res = c1++;
                Res.Print_Fraction(Res, c1, Operator);
                break;
            case "==":
                Console.WriteLine("Please Enter The Second Fraction Numerator2");
                c2.Numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter The Second Fraction Denominator2");
                c2.Denominator = int.Parse(Console.ReadLine());
                bool Res1 = c1 == c2;
                Res.Print_Fraction(c1, c2, Res1, Operator);
                break;
            default:
                break;
        }


        Console.WriteLine("\n-------------------------------- Try Again ---------------------------");

        Counter++;

    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


