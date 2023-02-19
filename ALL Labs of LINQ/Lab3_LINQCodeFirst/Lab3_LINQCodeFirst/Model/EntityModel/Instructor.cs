using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    //[Table("Inst",Schema ="iti")] //if you change table and schema
    class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // cancel default identity auto increase by 1
        public int Ins_Id { get; set; }
        [Required,MaxLength(50)]
        public string Ins_Name { get; set; }
        public string Ins_Degree { get; set; }
        [Required]
        public float Salary { get; set; } // any value type in sql not allow null
        [ForeignKey("Department")]
        public int Dno { get; set; }
        public Department Department { get; set; }

        public List<Ins_Course> Ins_Courses { get; set; }
        public List<Department> listDepartment { get; set; }
    }
}
