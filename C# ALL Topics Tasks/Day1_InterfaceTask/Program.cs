using System;

namespace Day1_InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {


            #region IComparable Interface Array of Object
            Cls_Point p1 = new Cls_Point(30, 9);
            Cls_Point p2 = new Cls_Point(10, 6);
            Cls_Point p3 = new Cls_Point(25, 8);
            Cls_Point[] Arrpoints = new Cls_Point[3] { p1, p2, p3 };
            // Icomparable
            Array.Sort(Arrpoints);

            foreach (var item in Arrpoints)
            {
                Console.WriteLine(item);
            }
            // Iclonable Object
            Cls_Point clone = (Cls_Point)p2.Clone();
            Console.WriteLine("The Clone Point is (" + clone.X + "," + clone.Y + ")");
            #endregion

            Console.WriteLine("********************** IComparer ********************** ");

            #region IComparer and IPayable Interface Array of Object Class Trainee
            Cls_Trainee[] trainees = new Cls_Trainee[6];
            trainees[0] = new Cls_Trainee() { traineeName = "Mahmoud", Salary = 5000 };
            trainees[1] = new Cls_Trainee() { traineeName = "Adel", Salary = 6000 };
            trainees[2] = new Cls_Trainee() { traineeName = "Samy", Salary = 3000 };
            trainees[3] = new Cls_Trainee() { traineeName = "Mahmoud", Salary = 1000 };
            trainees[4] = new Cls_Trainee() { traineeName = "Adel", Salary = 1000 };
            trainees[5] = new Cls_Trainee() { traineeName = "Samy", Salary = 1000 };
            // Icomparer Interface to compare Two values of object 
            Array.Sort(trainees,new Cls_Trainee());

            foreach (var item in trainees)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine("**********************************************************");

            #region IComparer and IPayable Interface Array of Object Class Trainee
            Cls_Employee[] employees = new Cls_Employee[3];
            employees[0] = new Cls_Employee() { employeeName = "Mona", Salary = 7000 };
            employees[1] = new Cls_Employee() { employeeName="Basem", Salary=10000 };
            employees[2] = new Cls_Employee() { employeeName="Ali", Salary=4000 };


            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine("*************************** Dictionary *******************************");

            #region Dictionary Phonebook

            #region Adding by Key and Value
            //Cls_PhoneBook<int, string> phoneBook = new Cls_PhoneBook<int, string>();
            //phoneBook.AddPhoneBook(123, "Ali");
            //phoneBook.AddPhoneBook(456, "Hosam");
            //phoneBook.AddPhoneBook(325, "Adel");

            //// print all items
            //phoneBook.PrintAllDictionaryItem();
            ////Search by key
            //phoneBook.SearchPhonebyKey(325);

            //// Search by Value
            //phoneBook.SearchPhonebyValue("Hosam"); 
            #endregion

            Cls_PhoneBook phoneBook = new Cls_PhoneBook();
            
            phoneBook[123] = "Adel";
            phoneBook["Ahmed"] = 456;
            phoneBook[321] = "Mohamed";
            phoneBook["Adel"] = 555;

            phoneBook.PrintAllDictionaryItem();

            Console.WriteLine("the key of Adel : " + phoneBook["Adel"]);


            #endregion
            Console.ReadKey();
           
        }
    }
}
