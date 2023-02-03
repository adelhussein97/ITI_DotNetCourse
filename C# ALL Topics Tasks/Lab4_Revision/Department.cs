using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab4_Revision
{
    delegate void DecreasDept(Employee employee);
  
    class Department
    {
        public int deptID { get; set; }

        public string deptName { get; set; }

        public int CountDept { get; set; }

        public List<Employee> ListofEmployees { get; set; }
        public Dictionary<int, Employee> DictEmp = new Dictionary<int, Employee>(); 
       
        public Employee this[int deptID]
        {
            get
            {
                return DictEmp[deptID];
            }
            set
            {
                DictEmp[deptID] = value;
            }
        }

       
        public Department()
        {
            ListofEmployees= new List<Employee>();
           


        }
        public Department(int id, string name)
        {
            ListofEmployees = new List<Employee>();
           
            deptID = id;
            deptName = name;

        }


        public event DecreasDept decreaseDel;
       
        public void DecreaseListEmployees(Employee employee)
        {
            ListofEmployees.Remove(employee);
            CountDept --; 
            decreaseDel(employee);
            
           

        }

        public void IncreaseListEmployees(Employee employee)
        {
            
             ListofEmployees.Add(employee);
             CountDept++;
               

        }


    }

}
