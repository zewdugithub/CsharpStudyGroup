using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //615-555-4578
            string pattern = @"(\d{3})-(\d{3})-(\d{4})";
            Console.WriteLine("Please Enter Your Phone Number");
            string Userphone = Console.ReadLine();
            Match match = Regex.Match(Userphone, pattern);
            if (match.Success)
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine(" Not Valid Phone Number");

            }
            
        }
    }
}
