using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YosephExampleRepractice
{
    internal class Grade
    {
        public int studentId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int age;
        public string garde;
        public string GetGrade(int mark) 
        {
            if (mark > 90) return "A";
            else if (mark > 80) return "B";
            else return "C";
        }
       
        
           
        
    }
}
