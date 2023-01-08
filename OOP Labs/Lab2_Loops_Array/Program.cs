using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Loops_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //********************************* Loops *******************************************

            #region Example 1.Print Multiples of num 4 from 0 to 100[for loop] مضاعفات الرقم 4
            try
            {
                

                for (int i = 0; i <= 100; i++)
                {
                   if(i % 4 == 0)
                    Console.WriteLine("Multiples of Num 4 : " + i);

                }
            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }

            #endregion

            #region Example 2. Calculate multiplication of 10 numbers givin by user [for loop].
            try
            {
                double User_Number = 0, Result_OfMultiplication = 1;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter the Number of : {i + 1}");
                    User_Number = Convert.ToDouble(Console.ReadLine());

                    Result_OfMultiplication *= User_Number;

                }
                Console.WriteLine($"The Result of Multiplication 10 Numbers = {Result_OfMultiplication}");
            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }
            #endregion

            #region Example 3. Print ASCII code for all char from 0-255 [for loop] 
            try
            {
                for (int i = 0; i <= 255; i++)
                {
                    Console.WriteLine($"The Ascii Code of {i} is : {Convert.ToChar(i)}");
                }
            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }
            #endregion

            #region Example 4. Get numbers from user until total reaches 100 [while]  3  50 37 20 
            try
            {
                int User_number = 0, Total = 0;
                while (Total <= 100)
                {
                    Console.WriteLine($"Enter the Number of : ");
                    User_number = Convert.ToInt32(Console.ReadLine());

                    Total += User_number;

                }
                Console.WriteLine($"The Total of User Number is : {Total}");
            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }
            #endregion

            #region Example 5. Print ASCII code a char from user until user press x [do while] 
            try
            {
                int User_AscuiiCode;
                char USerChar;
                do
                {
                    Console.WriteLine($"Please Enter any char to Show the Ascii Code :");
                    USerChar = Convert.ToChar(Console.ReadLine());
                    User_AscuiiCode = Convert.ToChar(USerChar);
                    Console.WriteLine($"The Ascii Code of {USerChar} is : {User_AscuiiCode}");
                } while (USerChar != 'x');
            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }

            #endregion

            #region Example 6. Print simple menu again inside do while. 
            try
            {
                /*  1.Add
                    2.Edit
                    3.Display
                    4.Exit 
               */
                int Menu_Number;
                do
                {
                    Console.WriteLine("Please Enter The Number of Menu : ");
                    Menu_Number = Convert.ToInt32(Console.ReadLine());
                    switch (Menu_Number)
                    {
                        case 1:
                            Console.Write($">> The Number of ( {Menu_Number} ). Add \n");
                            break;
                        case 2:
                            Console.Write($">> The Number of ( {Menu_Number} ). Edit \n");
                            break;
                        case 3:
                            Console.Write($">> The Number of ( {Menu_Number} ). Display \n");
                            break;
                        case 4:
                            Console.Write($">> The Number of ( {Menu_Number} ). Exit \n");
                            break;
                        default:
                            Console.Write($">> Sorry You Entered out Number of Menu Pls try (1 , 2 , 3 , 4) \n");
                            break;
                    }

                } while (Menu_Number > 0 && Menu_Number <= 4);

            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }
            #endregion


            // ********************************* Arrays ******************************************

            #region Example 1- Write a program to get sum of 1 student grades and get average and Greatest num then print message if "Success" or "Fail" 
            try
            {
                int SizeofArray;
                double Average = 0, Sum_Grades = 0, StdGreatest = 0;

                Console.WriteLine("Please Enter The Size of Array : ");
                SizeofArray = Convert.ToInt32(Console.ReadLine());
                double[] Student_Grades = new double[SizeofArray];

                for (int i = 0; i < Student_Grades.Length; i++)
                {
                    Console.WriteLine($"Please Enter The Grade of Material : {i + 1}");
                    Student_Grades[i] = Convert.ToDouble(Console.ReadLine());
                    Sum_Grades += Student_Grades[i];
                }
                // Total Grade
                Console.WriteLine($"The Total of Student Grade is : {Sum_Grades} ");
                // Greatest Grade using built in function max
                Console.WriteLine($"The Greatest Grade is : {Student_Grades.Max()} ");

                // or using for loop and set the greatest in variable
                // set default the largest is first grade in array
                StdGreatest = Student_Grades[0];
                for (int i = 1; i < Student_Grades.Length; i++)
                {
                    if (StdGreatest < Student_Grades[i])
                        StdGreatest = Student_Grades[i];
                }
                Console.WriteLine($"The Greatest Grade is : {StdGreatest} ");
                // Average of Grades
                Average = Sum_Grades / SizeofArray;
                if (Average > 50)
                    Console.WriteLine("The Status of Student is : Success ");
                else
                    Console.WriteLine("The Status of Student is : Fail ");


            }
            catch
            {
                Console.WriteLine("There is an error pls try to solve it");
            }
            #endregion



            #region Example 2- For 1D array , Try Resize and Delete by Shifting 
            int index_Delete;
            int[] Arra_Testing = new int[]
            {
                5 , 10 , 25, 30, 45,20,30
            };
            Console.WriteLine("The Array Before Shifiting :");
            for (int i = 0; i < Arra_Testing.Length; i++)
            {
                Console.Write(Arra_Testing[i] + " , ");
            }

            Console.WriteLine("\nPlease Enter the Index to delete it and shifiting the remaining item : \n");
            index_Delete = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Arra_Testing.Length; i++)
            {

                if (index_Delete == i)
                {
                    for (int j = i; j < Arra_Testing.Length - 1; j++)
                    {
                        Arra_Testing[j] = Arra_Testing[j + 1];


                    }
                    // set the last item in array equal 0
                    Arra_Testing[Arra_Testing.Length - 1] = 0;
                    break;
                }



            }
            Console.WriteLine("The Array After Shifiting :");
            for (int i = 0; i < Arra_Testing.Length; i++)
            {
                Console.Write(Arra_Testing[i] + " , ");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
