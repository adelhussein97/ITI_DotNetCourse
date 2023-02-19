using Lab3_LINQCodeFirst.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // cancel default identity auto increase by 1
        public int Crs_Id { get; set; }
        [Required, MaxLength(50)] // not allow null
        public string Crs_Name { get; set; }
        public int Crs_Duration { get; set; }

        [ForeignKey("Topic")]
        public int Topic_ID { get; set; }
        public Topic Topic { get; set; } // Create Naavigation Property

        public List<Stud_Course> Stud_Courses { get; set; } // Many to Many Relations

        public List<Ins_Course> Ins_Courses { get; set; }   // Many to Many Relations
    }
}
