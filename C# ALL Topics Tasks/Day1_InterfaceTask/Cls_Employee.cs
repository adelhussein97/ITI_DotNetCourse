using System;
using System.Collections.Generic;
using System.Text;

namespace Day1_InterfaceTask
{
    class Cls_Employee : IPayable
    {
        public string employeeName { get; set; }
        int salary;
        // Implement Salary property for Interface
        public int Salary { get => salary; set => salary=value; }

        // Implement IPayable Methods
        public int ShowPayment()
        {
            return Salary;
        }

        public override string ToString()
        {
            return "Employee ( "+employeeName+","+ShowPayment()+")";
        }
    }
}
