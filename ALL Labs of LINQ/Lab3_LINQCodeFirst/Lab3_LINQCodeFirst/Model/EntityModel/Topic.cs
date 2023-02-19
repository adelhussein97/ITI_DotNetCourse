using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab3_LINQCodeFirst.Model.EntityModel
{
    class Topic
    {
        [Key]
        public int Top_ID { get; set; }
        public string Top_Name { get; set; }
    }
}
