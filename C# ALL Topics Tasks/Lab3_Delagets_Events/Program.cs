using System;
using System.Collections.Generic;

namespace Lab3_Delagets_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empArr = new List<Employee>()
            { 
               new Employee("Adel", 4000),
               new Employee("Mohamed", 10000),
               new Employee("Ali", 8000),
               new Employee("Sameh", 3000),
            };
            Employee employee = new Employee(empArr);

            Console.WriteLine("********************** Before Increasing *******************");
            foreach (Employee item in empArr)
            {
                Console.WriteLine($"EmpName : {item.empName} , Salary : {item.empSalary}");
            }

            // Using First Delgate to fire event of company to decrease budget

            
            Company company = new Company();
           
            Console.WriteLine($"Company Name : {company.companyName} , Budget : {company.companyBudget}");
            empArr[1].NotifySalary += company.NotifyDecreaseBudget;
            empArr[1].IncreaseSalary(4000);
            
            Console.WriteLine("********************** After Increasing *******************");

            foreach (Employee item in empArr)
            {
                Console.WriteLine($"EmpName : {item.empName} , Salary : {item.empSalary}");
            }
            Console.WriteLine($"Company Name : {company.companyName} , Budget : {company.companyBudget}");


            Console.WriteLine("****************************After Filter ***********************");

            //List<Employee> filteredEmp = company.FilterEmp(empArr, delegate (Employee emp) { return emp.empSalary > 4000; });
            // or using LLamda Expression
            List<Employee> filteredEmp = company.FilterEmp(empArr, (Employee emp)=>emp.empSalary > 4000);

            foreach (Employee item in filteredEmp)
            {
                Console.WriteLine($"EmpName : {item.empName} , Salary : {item.empSalary}");
            }


            Console.ReadKey();
        }
    }
}
