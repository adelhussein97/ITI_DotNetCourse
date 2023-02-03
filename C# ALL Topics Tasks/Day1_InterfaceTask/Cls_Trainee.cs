using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Day1_InterfaceTask
{
    class Cls_Trainee : IPayable, IComparer<Cls_Trainee>
    {
        public string traineeName { get; set; }
        int salary=0;
        // Implement Salary property for Interface
        public int Salary 
        {
            set => salary = value;
            get => salary;
        }

        public int ShowPayment()
        {
            return Salary;
        }

        public int Compare(Cls_Trainee x, Cls_Trainee y)
        {
            int res = x.Salary.CompareTo(y.Salary);

            if (res == 0) //Equal values if equal compare with trainee name
            {
                res = x.traineeName.CompareTo(y.traineeName);
            }

            return res;
        }

        public override string ToString()
        {
            return "Trainee : (" + traineeName + "," + ShowPayment() + ")";

        }
    }
}
