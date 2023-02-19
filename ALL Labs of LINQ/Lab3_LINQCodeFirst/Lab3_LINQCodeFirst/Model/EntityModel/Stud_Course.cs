using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    class Stud_Course
    {
        public int ID { get; set; }
        [Key] 
        [Column(Order = 1)] // composit pk
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Student")] // composit pk
        public int St_Id { get; set; }
        public int Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
