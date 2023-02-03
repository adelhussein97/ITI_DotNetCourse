using System;
using System.Collections.Generic;
using System.Text;

namespace Day1_InterfaceTask
{
    interface IPayable
    {
        int Salary{ get; set; }

        int ShowPayment();
    }
}
