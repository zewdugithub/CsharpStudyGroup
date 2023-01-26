using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department();
            int _DepartmentId = d.DepartmentId;
            Console.WriteLine("The Department Id you Entered is {0}" , d.DepIdEvenOrOdd(_DepartmentId));
            Console.ReadLine();
        }
    }
}
