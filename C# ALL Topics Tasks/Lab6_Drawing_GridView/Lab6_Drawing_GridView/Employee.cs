using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Drawing_GridView
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string Birthday { get; set; }

        public Employee(string name,int age, string address,string birthday)
        {
            Name = name;
            Age = age;
            Address = address;
            Birthday = birthday;
        }

        public Employee()
        {
        }
    }
}
