using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    class Student
    {
        // Fields of Class

        #region Fields
        string name;
        int age;
        public static int size = 0;
        public int[] grade = null;
        string password;
        private string username; 
        #endregion

        // Properties of Class
        #region Property Size of Array Grade
        public int Size
        {
            get { return size; }
            set { size = value; }
        } 
        #endregion

        #region Property Name > 5
        public string Name
        {

            set
            {
                if (value.ToString().Length > 5)
                    name = value;
                else
                    throw new Exception("Pls Enter the name Larger than 5");

            }
            get { return name; }
        } 
        #endregion

        #region Property Age > 20
        public int Age
        {
            get { return age; }
            set
            {
                if ((int)value > 20)
                    age = value;
                else
                    throw new Exception("Pls Enter the age Larger than 20");
            }
        }
        #endregion

        #region Property Username
        public string Username {  get { return name + age; } }
        #endregion

        #region PRoperty Address
        public string Address { get; set; } 
        #endregion

        #region PRoperty Password
        public string Password
        {
            private get { return password; }
            set
            {
                if ( ValidatePassword(value.ToString()) == true)
                    password = value;
                else
                    throw new Exception("Password must have 8 Char and Contains Upper & Lower & Char .%@#*");

            }
        } 
        #endregion


        // Methods of Class 

        #region Validate PAssword Expression
        private bool ValidatePassword(string password)
        {
            
                int validConditions = 0;
                foreach (char c in password)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        validConditions++;
                        break;
                    }
                }
                foreach (char c in password)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        validConditions++;
                        break;
                    }
                }
                if (validConditions == 0) return false;
                foreach (char c in password)
                {
                    if (c >= '0' && c <= '9')
                    {
                        validConditions++;
                        break;
                    }
                }
                if (validConditions == 1) return false;
                if (validConditions == 2)
                {
                    char[] special = { '@', '#', '$', '%', '^', '&', '+', '=' }; // or whatever    
                    if (password.IndexOfAny(special) == -1) return false;
                }
                return true;
            

        } 
        #endregion

        #region Forget Password
        public string ForgetPassword(string _Username)
        {
            if (Username == _Username)
            {
                // Generate a random number  
                Random random = new Random();
                // Any random integer   
                password = random.Next().ToString();
                return password;
            }
            else
                throw new Exception("Username not found pls try username correct");
        } 
        #endregion

        #region Set Array Grade
        public void FillGrade()
        {
            grade = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the Student Grade : {i + 1}");
                grade[i] = int.Parse(Console.ReadLine());

            }
        }

        #endregion

    }
}
