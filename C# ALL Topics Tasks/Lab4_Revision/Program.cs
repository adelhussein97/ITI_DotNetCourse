using System;
using System.Collections.Generic;

namespace Lab4_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3]
            {
                new Employee(111,"Mohamed",25,6500,5,2),
                new Employee(444,"Adel",25,8500,3,1),
                new Employee(555,"Saleh",25,3000,7,1),
            };

            Department dept = new Department(1, "IT");
            Department d2 = new Department(2, "IT");



            dept.ListofEmployees.AddRange(emp);

            // Sorting Employees Array  Sorting by Years Experience
            Array.Sort(emp);
            Console.WriteLine("********************************** Sorting by Experience ***************************\n");
            foreach (Employee item in emp)
            {
                
                 Console.WriteLine($"Emp ID : {item.empID} , Emp Name : {item.empName} , EmpExperience : {item.yearsofExperience} ");

            }
            Console.WriteLine("********************************** Sorting Array by Salary ***************************\n");
            // Sorting Employees  by Salary
            Array.Sort(emp,new EmployeesSalary());
            foreach (Employee item in emp)
            {
                Console.WriteLine($"Emp ID : {item.empID} , Emp Name : {item.empName} , EmpExperience : {item.empSalary} ");

            }
            Console.WriteLine("********************************** Sorting List by Salary ***************************\n");

            //sorting by List of Salary
            dept.ListofEmployees.Sort(new EmployeesSalary());
            foreach (Employee item in dept.ListofEmployees)
            {
                Console.WriteLine($"Emp ID : {item.empID} , Emp Name : {item.empName} , EmpExperience : {item.empSalary} ");

            }

            Console.WriteLine("********************************** Adding and Searching in Dictionary *******************\n");
            dept.DictEmp[5]=  emp[0];
            dept.DictEmp[6] = emp[1];
            dept.DictEmp[7] = emp[2];

            Console.WriteLine($"Emp Name : {dept.DictEmp[6].empName} , Emp Salary : {dept.DictEmp[6].empSalary}");


            Department dept1 = new Department();
            Department dept2 = new Department();
            dept1.CountDept = 5;
            dept2.CountDept = 8;
            dept1.ListofEmployees.AddRange(emp);
            dept2.ListofEmployees.Add(emp[0]);
            dept2.ListofEmployees.Add(emp[2]);

            emp[1].changedept += dept1.DecreaseListEmployees;
           
            dept1.decreaseDel += dept2.IncreaseListEmployees;
            emp[1].ChangeDepartment(d2);

            Console.WriteLine($"dept1 : { dept1.CountDept}");
            Console.WriteLine($"dept2 : { dept2.CountDept}");
            Console.WriteLine("--------------------------Before Moving--------------------------\n");

            foreach (Employee item in dept1.ListofEmployees)
            {
                Console.WriteLine($"Emp ID : {item.empID} , Emp Name : {item.empName} , EmpExperience : {item.empSalary} ");

            }
            Console.WriteLine("--------------------------After Moving--------------------------\n");
            foreach (Employee item in dept2.ListofEmployees)
            {
                Console.WriteLine($"Emp ID : {item.empID} , Emp Name : {item.empName} , EmpExperience : {item.empSalary} ");

            }








            Console.ReadKey();
        }
    }
}
