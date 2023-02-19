using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // cancel default identity auto increase by 1
        public int Std_ID { get; set; }
        [Required , MaxLength(50)]
        public string St_Fname { get; set; }
        [Required,MaxLength(50)]
        public string St_Lname { get; set; }
        [MaxLength(100)]
        public string St_Address { get; set; }
        public int St_Age { get; set; }

        [ForeignKey("Department")]
        public int Dept_ID { get; set; }

        [ForeignKey("St_MGRSuper")]
        public int? St_Super { get; set; }

        public Department Department { get; set; }
        public Student St_MGRSuper { get; set; }

        public List<Stud_Course> Stud_Courses { get; set; } // Many to Many Relations

    }
}
