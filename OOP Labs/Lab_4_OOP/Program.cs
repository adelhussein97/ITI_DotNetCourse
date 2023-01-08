using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                #region Students Grade With Fields & Property & Methods
                Student Std1 = new Student();

                Console.WriteLine("Please Enter the Student Name :");
                Std1.Name = Console.ReadLine();
                Console.WriteLine("Please Enter the Student Age :");
                Std1.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the Student Address :");
                Std1.Address = Console.ReadLine();
                Console.WriteLine("Please Enter the Student Grades Numbers :");
                Std1.Size = int.Parse(Console.ReadLine());

                Std1.FillGrade();

                Console.WriteLine("Please Enter the Student Password :");
                Std1.Password = Console.ReadLine();

                Console.WriteLine("IF you Forget your Password write your username :");
                String Username = Console.ReadLine();
                string NewPAssword=Std1.ForgetPassword(Username);


                Console.WriteLine("*************************** Your Data is : *********************************");
                Console.WriteLine($"  Name : {Std1.Name } \n Age : {Std1.Age} \n Address : {Std1.Address} \n Grades : ");
                for (int i = 0; i < Std1.Size; i++)
                {
                    Console.Write($"  {Std1.grade[i]}   ,");
                }
                Console.WriteLine($"\n  Your Username : {Std1.Username} \n New PAssword : {NewPAssword}");
                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.ReadKey();
        }
    }
}
