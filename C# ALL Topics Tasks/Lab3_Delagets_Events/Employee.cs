using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Delagets_Events
{
    delegate void NotifyCompanyIncreaseSalary(float salary);
    class Employee
    {
        public string empName { get; set; }
        public float empSalary { get; set; }
        public List<Employee> EmpArr { get; }

        public Employee(string Name,float Salary)
        {
            empName = Name;
            empSalary = Salary;
        }

        public Employee(List<Employee> empArr)
        {
            EmpArr = empArr;
        }
        // Create Refernce of Delegate
        public event NotifyCompanyIncreaseSalary NotifySalary;

        public void IncreaseSalary(float Amount)
        {
            empSalary += Amount;
            NotifySalary.Invoke(Amount);
            
           
           
        }
    }
}
