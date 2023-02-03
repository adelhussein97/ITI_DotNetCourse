using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Delagets_Events
{
    delegate bool FilterEmployeesDelgate(Employee employee);
    class Company
    {
        public string companyName { get; set; }
        public float companyBudget { get; set; }


        List<Employee> compEmployees = new List<Employee>();
        public Company(string Name, float Budget)
        {
            companyName = Name;
            companyBudget = Budget;
        }

        public Company()
        {
            companyName = "ITech";
            companyBudget = 50000;
        }
      
       
        public void NotifyDecreaseBudget(float DecreaseAmount)
        {
            companyBudget -= DecreaseAmount;
            Console.WriteLine("The Budget after decreasing"+companyBudget);
          
        }
        // Create Refernce of Delgate filter Salary
        public List<Employee> FilterEmp(List<Employee> employees,FilterEmployeesDelgate checkFilter)
        {
            
            foreach (Employee item in employees)
            {
                if (checkFilter.Invoke(item))
                    compEmployees.Add(item);
            }
            return compEmployees;
        }
    }
}
