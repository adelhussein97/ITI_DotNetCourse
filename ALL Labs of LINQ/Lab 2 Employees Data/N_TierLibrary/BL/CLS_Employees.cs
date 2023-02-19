using DALContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace N_TierLibrary
{
   public class CLS_Employees
    {
        Company_SDEntities db = new Company_SDEntities();

        public System.Collections.IEnumerable Select_Employees()
        {

            var res= db.Employees.Select(e => new {e.SSN, e.Fname,e.Lname,e.Salary,e.Dno}).ToList();
            return res;
            
        }

        public void InsertEmp(Employee emp)
        {
            db.Employees.Add(emp);
            db.SaveChanges();
           
           
        }
        public void UpdateEmp(Employee emp)
        {
            var employee = db.Employees.Where(e => e.SSN == emp.SSN).FirstOrDefault();
            employee.SSN = emp.SSN;
            employee.Fname = emp.Fname;
            employee.Lname = emp.Lname;
            employee.Salary = emp.Salary;
            employee.Dno = emp.Dno;
            db.SaveChanges();

        }
        public void DeleteEmp(int EmpID)
        {
            
            var employee = db.Employees.Where(e => e.SSN == EmpID).FirstOrDefault();
            db.Employees.Remove(employee);
            db.SaveChanges();

        }

        public int GetLastID()
        {
            var lastid = db.Employees.Max(e => e.SSN + 1);
            return lastid;
        }

    }
}
