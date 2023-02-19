using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    class Department
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] // cancel default identity auto increase by 1
        public int Dept_Id { get; set; }

        [Required,MaxLength(50)]
        public string Dept_Name { get; set; }
        public string Dept_Desc { get; set; }
        public string Dept_Location { get; set; }
       
        public DateTime ? Manager_Hiredate { get; set; }

        [ForeignKey("InstructorMgr")]
        public int? Dept_Manager { get; set; }
        public Instructor InstructorMgr { get; set; }

        public List<Instructor> listInstructors { get; set; }
        public List<Student> listStudent { get; set; }
    }
}
