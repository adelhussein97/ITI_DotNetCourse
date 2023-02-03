using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Drawing_GridView
{
    class Cls_Lab 
    {
       
        public int labID { get; set; }
        public string trainneName { get; set; }
         
        public override string ToString()
        {
            return trainneName.ToString();
        }


    }
}
