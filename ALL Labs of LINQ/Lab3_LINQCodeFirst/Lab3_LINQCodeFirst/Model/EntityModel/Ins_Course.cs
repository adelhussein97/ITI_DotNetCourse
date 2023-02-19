using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    class Ins_Course
    {
        public int ID { get; set; }

        [Key]
        [Column(Order =1)] // Composit pk
        [ForeignKey("Instructor")]
        public int Ins_Id { get; set; }
        [Key]
        [Column(Order = 2)] // composit pk
        [ForeignKey("Course")]
        public int Crs_Id { get; set; }
        public int Evaluation { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
