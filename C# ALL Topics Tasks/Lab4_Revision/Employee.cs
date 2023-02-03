using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab4_Revision
{
    delegate void ChangeEmployeeDept(Employee emp);
    class Employee:IComparable<Employee>
    {
        public int empID { get; set; }

        public string empName { get; set; }
        public int empAge { get; set; }
        public float empSalary { get; set; }
        public int yearsofExperience { get; set; }

        public int deptID { get; set; }

        public Employee(int id,string name,int age,float salary,int noExp,int deptid)
        {
            empID = id;
            empName = name;
            empAge = age;
            empSalary = salary;
            yearsofExperience = noExp;
            deptID = deptid;
        }

        public int CompareTo(Employee other)
        {
            return yearsofExperience.CompareTo(other.yearsofExperience);
        }

        // Call Refernce from delgate if 0 decrease count else 1 increase count
        public event ChangeEmployeeDept changedept;

        public void ChangeDepartment(Department _deptid)
        {

            deptID = _deptid.deptID;
            _deptid.CountDept--;
            changedept.Invoke(this);

        }
             

    }
    class EmployeesSalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.empSalary.CompareTo(y.empSalary);
        }


    }
}
