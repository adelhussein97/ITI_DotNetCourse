using DALContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace N_TierLibrary
{
   public class CLS_Department
    {
        Company_SDEntities db = new Company_SDEntities();
       

        public System.Collections.IEnumerable Select_Department()
        {
            var dept = db.Departments.Select(d=>new {d.Dnum,d.Dname }).ToList();
            return dept;
        }

        public void InsertDept(Department dept)
        {
            db.Departments.Add(dept);
            db.SaveChanges();
           
           

        }
        public void UpdateDept(Department dept)
        {
            var department = db.Departments.Where(d => d.Dnum == dept.Dnum).FirstOrDefault();
            department.Dnum = dept.Dnum;
            department.Dname = dept.Dname;
            db.SaveChanges();


        }
        public void DeleteDept(int DeptID)
        {
            var department = db.Departments.Where(d => d.Dnum == DeptID).FirstOrDefault();
            db.Departments.Remove(department);
            db.SaveChanges();


        }
        public int SelectLastDeptID()
        {
            var id = db.Departments.Max(d => d.Dnum + 1);
            return id;
        }

    }
}
