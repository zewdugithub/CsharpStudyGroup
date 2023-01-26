using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int FacultyId { get; set; }

        public string DepIdEvenOrOdd(int _DepartmentId)
        {
            Console.WriteLine("Please Enter Enter Departmen Id?");
            _DepartmentId = int.Parse(Console.ReadLine());
            if (_DepartmentId % 2 == 0)
                return "Even";
            else
                return "Odd";
            
        }
    }
}
