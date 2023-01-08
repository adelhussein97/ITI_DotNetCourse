using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Lab1Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1 To  print "Hello World"
            // 1- write a program to print "Hello World"
            Console.WriteLine("Ex1 : Hello World ");
            Console.WriteLine("\n*******************************************************************************************");

            #endregion

            #region Example 2 to print area of circle = 3.14 * radius * radius 
            // 2- write a program to print area of circle = 3.14 * radius * radius 
            try
            {
                float radius = 0;
                double Result_AreaOfCircle = 0;
                Console.WriteLine("Ex2 : Enter The Radius of Area : ");
                radius = float.Parse(Console.ReadLine());
                Result_AreaOfCircle = 3.14 * radius * radius;
                Console.WriteLine($">> The Result of Area of Circle =3.14 * {radius} * {radius} = {Result_AreaOfCircle}");
                Console.WriteLine("\n******************************************************************************************* ");

            }
            catch (Exception)
            {
                Console.WriteLine($">>Please Enter a Valid Number Not Char");
                Console.WriteLine("\n******************************************************************************************* ");

            }
            #endregion

            #region Example 3 write a porgram to print + , - , / , * of 2 numbers
            // 3. write a porgram to print + , - , / , * of 2 numbers 
            int First_Number = 0, Second_Number = 0;

            try
            {
                // Set the Values from Users
                Console.WriteLine("Ex3 : Enter The First Number : ");
                First_Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ex3 : Enter The Second Number : ");
                Second_Number = Convert.ToInt32(Console.ReadLine());
                // Add + Operators
                Console.WriteLine($">> The Sum of Two Number = {First_Number} + {Second_Number} = {First_Number + Second_Number}");
                // Subtract - Operators
                Console.WriteLine($">> The Subtract of Two Number = {First_Number} - {Second_Number} = {First_Number - Second_Number}");
                // Multiply * Operators
                Console.WriteLine($">> The Multiply of Two Number = {First_Number} * {Second_Number} = {First_Number * Second_Number}");
                // Division / Operators
                Console.WriteLine($">> The Division of Two Number = {First_Number} / {Second_Number} = {First_Number / Second_Number} ");
                Console.WriteLine("\n******************************************************************************************* ");

            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter The Integer Number or Charchters, Try Again ");
                Console.WriteLine("\n******************************************************************************************* ");

            }
            #endregion

            #region Example 4 write a program to print ascii number of any character(bouns)
            // to convert any char to machine language by Ascii Code
            int asciiValue;
            Console.WriteLine("Ex4 Please Write any Char to Print The Ascii Code : ");
            asciiValue = Convert.ToChar(Console.ReadLine());

            Console.Write(">> The Ascii Code of Char ( " + Convert.ToChar(asciiValue) + " ) is : " + asciiValue);
            Console.WriteLine("\n******************************************************************************************* ");

            #endregion

            #region Example 5 Get a number from a user & checking if it is Even Or Odd Or Zero using if ...else statement.
            try
            {
                int Number = 0;
                Console.WriteLine("Ex5 Please Enter the Number to check it Even or Odd or Zero : ");
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number % 2 == 0 && Number != 0)
                {
                    Console.Write($">> The Number of ( {Number} ) is Even");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
                else if (Number % 2 == 1)
                {
                    Console.Write($">> The Number of ( {Number} ) is Odd");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
                else
                {
                    Console.Write($">> The Number of ( {Number} ) is Zero");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
            }
            catch (Exception)
            {
                Console.Write($">> Please Enter A Number not Char Try Again...");
                Console.WriteLine("\n******************************************************************************************* ");

            }

            #endregion

            #region Example 6 Getting grade of a student as int, and printing it as char using if ...else statement:
            /*  90 and above      A
                80 to 90          B
                70 to 80          C
                60 to 70          D
                Below 60          F*/
            try
            {
                double Grade = 0;
                Console.WriteLine("Ex6 Please Enter your Grade to Show The Rate : ");
                Grade = Convert.ToDouble(Console.ReadLine());
                if (Grade >= 90)
                {
                    Console.Write($">> The Grade of  ( {Grade} ) is : A");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
                else if (Grade >= 80 )
                {
                    Console.Write($">> The Grade of  ( {Grade} ) is : B");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
                else if (Grade >= 70 )
                {
                    Console.Write($">> The Grade of  ( {Grade} ) is : C");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
                else if (Grade >= 60 )
                {
                    Console.Write($">> The Grade of  ( {Grade} ) is : D");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
                else if (Grade < 60)
                {
                    Console.Write($">> The Grade of  ( {Grade} ) is : F");
                    Console.WriteLine("\n******************************************************************************************* ");

                }
            }
            catch (Exception)
            {
                Console.Write($">> Please Enter A Number not Char Try Again...");
                Console.WriteLine("\n******************************************************************************************* ");

            }


            #endregion

            #region Example 7 Printing a simple menu using switch:
            /*   1.Add
                 2.Edit
                 3.Display
                 4.Exit */
            try
            {
                int NumberofMenu = 0;
                Console.WriteLine("Ex7 Please Enter The Number of Menu : ");
                NumberofMenu = Convert.ToInt32(Console.ReadLine());
                switch (NumberofMenu)
                {
                    case 1:
                        Console.Write($">> The Number of ( {NumberofMenu} ). Add");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    case 2:
                        Console.Write($">> The Number of ( {NumberofMenu} ). Edit");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    case 3:
                        Console.Write($">> The Number of ( {NumberofMenu} ). Display");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    case 4:
                        Console.Write($">> The Number of ( {NumberofMenu} ). Exit");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    default:
                        Console.Write($">> Sorry You Entered out Number of Menu Pls try (1 , 2 , 3 , 4)");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine($">>Please Enter a Valid Number Not Char");
                Console.WriteLine("\n******************************************************************************************* ");

            }

            #endregion

            #region Example 8 update in problem no 3 , Take 2 numbers And Operator(+,/,-,*), then Print Result
            try
            {
                double First_No = 0, Second_No = 0;
                char Operator;
                Console.WriteLine("Ex8 Please Enter The First Number of Calculation : ");
                First_No = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter The Second Number of Calculation : ");
                Second_No = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter The Operator of Calculation : ");
                Operator = Convert.ToChar(Console.ReadLine());
                switch (Operator)
                {
                    case '+':
                        Console.Write($">> The Result = {First_No} {Operator} {Second_No} = {First_No + Second_No} ");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    case '-':
                        Console.Write($">> The Result = {First_No} {Operator} {Second_No} = {First_No - Second_No}");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    case '*':
                        Console.Write($">> The Result = {First_No} {Operator} {Second_No} = {First_No * Second_No}");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    case '/':
                        Console.Write($">> The Result = {First_No} {Operator} {Second_No} = {First_No / Second_No}");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                    default:
                        Console.Write($">> Please enter The only one of Arthimatic operator ( + , - , * , / )");
                        Console.WriteLine("\n******************************************************************************************* ");
                        break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine($">>Please Enter a Valid Number Not Char For First Number and Second Number");
                Console.WriteLine("\n******************************************************************************************* ");

            }

            #endregion

            Console.WriteLine("\n******************************************************************************************* ");
            Console.WriteLine("If You Finished Testing can press on any key to Exit App");
            // To Show the Screen Result and fixed it to read the result
            Console.ReadKey();
        }
    }
}
