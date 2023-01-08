using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2D_Array_Functions
{
    class Program
    {
        #region Fill array 2D take rows and col size and start to insert the grades of students
        static int[,] FillArray2D()
        {
            Console.WriteLine($"Enter Student Array Rows Number");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Student Array Columns Number");
            int col = int.Parse(Console.ReadLine());
            int[,] StudentArray = new int[row, col];
            // Fill array columns wwith columns
            for (int i = 0; i < StudentArray.GetLength(1); i++) // columns get by 1
            {
                for (int j = 0; j < StudentArray.GetLength(0); j++)  // Rows get by 0
                {
                    Console.WriteLine($"StudentArray columns std [{j} , {i}]");
                    StudentArray[j, i] = int.Parse(Console.ReadLine());
                }
            }
            return StudentArray;

        }
        #endregion

        #region Print the Array 2D after filling it
        static void PrintArra2D(int[,] arr)
        {
            Console.WriteLine("\nThe Students Array Grade is : \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine("\n");
            }
        }
        #endregion

        #region Calculate the Sum of Columns for Array 2D Based on Column >> 1
        static void PrintSumColumnsArra2D(int[,] arr)
        {
            // Sum Array based on columns 
            int[] SumArray = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    SumArray[i] += arr[j, i];
                }

                Console.Write($"{SumArray[i]}   ");

            }
        }
        #endregion

        #region Add New Item to Array 1D one by one To catch current index must define it ref type
        static void FillArrayGradeOneByOneValue(ref int Currentindex,int [] StudentArray, int Grade)
        {
            
           if(Currentindex<StudentArray.Length)
            {
                StudentArray[Currentindex] = Grade;
                Currentindex++;
            }
           
           // return StudentArray;
        }
        #endregion

        #region Display Array 1D After Filling it
        static void DisplayArray(int[] arr)
        {
            Console.WriteLine("Display The Array 1D For Student  :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} , ");
            }
        }
        #endregion

        #region Delete Specific Item from Array 1D
        static void DeleteFrommArray(int index_Delete, int[] Arra_Testing)
        {

            index_Delete -= 1;  // To Select the index user enter 3rd item and for me 0 , 1 , 2 is 2

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

            Console.WriteLine("The Array After Deleting :");
            for (int i = 0; i < Arra_Testing.Length; i++)
            {
                Console.Write(Arra_Testing[i] + " , ");
            }


        }
        #endregion

        #region Update Specific Item in Array 1D
        static void EditItemFromArray(int index_Delete, int NewValue, int[] Arra_Testing)
        {

            index_Delete -= 1;  // To Select the index user enter 3rd item and for me 0 , 1 , 2 is 2

            Arra_Testing[index_Delete] = NewValue;  //set value

            Console.WriteLine("The Array After Editing :");
            for (int i = 0; i < Arra_Testing.Length; i++)
            {
                Console.Write(Arra_Testing[i] + " , ");
            }


        }
        #endregion

        #region Simple Menu To Choose from app ( Add | Edit | Delete | Display | Exit App )
        static void SimpleMenu()
        {
            Console.WriteLine("\n ---To Use The Menu write 1.add  2.Edit  3.Delete  4.Display  5.Exit  // To stop insert press 0 key \n --");
            Console.WriteLine("Please Enter The Size of Array 1D");
            int Size = int.Parse(Console.ReadLine());
            int[] arr = new int[Size];
            int Menu_Number = 0, index = 0, NewValue = 0;
            do
            {
                Console.WriteLine("\nPlease Enter The Number of Menu : 1.add  2.Edit  3.Delete  4.Display  5.Exit ");
                Menu_Number = Convert.ToInt32(Console.ReadLine());
                switch (Menu_Number)
                {
                    case 1:  // Add
                        Console.WriteLine("Please Enter The Grade of Array 1D To Add");
                        int Grade = int.Parse(Console.ReadLine());
                        FillArrayGradeOneByOneValue(ref index,arr,Grade);
                        DisplayArray(arr);
                        break;
                    case 2:  // Edit
                        Console.WriteLine("Please Enter Index To Edit it :");
                        index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter New Value :");
                        NewValue = int.Parse(Console.ReadLine());
                        EditItemFromArray(index, NewValue, arr);
                        break;
                    case 3: // Delete
                        Console.WriteLine("Please Enter Index To Delete it :");
                        index = int.Parse(Console.ReadLine());
                        DeleteFrommArray(index, arr);
                        break;
                    case 4: // Display
                        DisplayArray(arr);
                        break;
                    case 5: // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write($">> Sorry You Entered out Number of Menu Pls try (1 , 2 , 3 , 4 ,5) \n");
                        break;
                }

            } while (Menu_Number > 0 && Menu_Number <= 5);
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Example 1 Fill Array 2D and Print Function Array 2D
            // Calling The Fill Functions Array 2D
            int[,] arr = FillArray2D();
            PrintArra2D(arr);
            #endregion

            #region Sum Columns Array And display It
            Console.WriteLine("The Sum of Columns Array is :");
            PrintSumColumnsArra2D(arr);
            #endregion

            Console.WriteLine("\n-------------------------------------Simple Menu-----------------------------------------------");

            #region Simple Menu 1.Add  2.Edit 3.Delete 4.Display 5.Exit
            SimpleMenu();
            #endregion

            Console.ReadKey();
        }

        
    }
}
