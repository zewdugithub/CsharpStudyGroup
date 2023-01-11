using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace YosephExampleRepractice
{
    internal class student 
    {
   
            public string _Fname { get; set; }
            public string _Lname { get; set; }
            public DateTime _DOB { get; set; }
            public string _Gender { get; set; }
            public string _Email { get; set; }

           
            public void getstudentInfo()
            {
                Console.WriteLine("Student Information: {0} ", this._Fname + " " + this._Lname + " " + this._Gender + " " + this._DOB);
                Console.ReadLine();
            }

       
       
            
                
               
                    







        }      
}
