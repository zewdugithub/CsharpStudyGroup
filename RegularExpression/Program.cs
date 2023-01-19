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
            /*
          1  //Phone Number 615-555-4578
            string pattern = @"(\d{3})-(\d{3})-(\d{4})";
            Console.WriteLine("Please Enter Your Phone Number");
            string Userphone = Console.ReadLine();
            Match match = Regex.Match(Userphone, pattern);
            if (match.Success)
            {
                Console.WriteLine("Valid Phone Number...");
            }
            else
            {
                Console.WriteLine(" Not Valid Phone Number...");

            }
            
            // validate ssn number: 123-36-2023

            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            Console.WriteLine("Please enter your SSN");
            string Userssn = Console.ReadLine().ToString();
            //string Userssn = "760-03-4719";
            //Match match = Regex.Match(pattern, Userssn);
            if (Regex.IsMatch(Userssn, pattern))
            {
                Console.WriteLine("valid SSN" + " " + Userssn);
            }
            else
            {
                Console.WriteLine("not valid SSN" + " " + Userssn);
            }
            //option 2
            Console.WriteLine("Please enter your SSN");
            string ssn = Console.ReadLine();
            if (Regex.IsMatch(ssn, @"^\d{3}-\d{2}-\d{4}$"))
            {
                Console.WriteLine("valid SSN" + " " + ssn);
            }
            else
            {
                Console.WriteLine("not valid SSN" + " " + ssn);
            }
            */
            // email address: alphanumericcharactors= 123---9 ,a-z or A-Z ,@ redwanomer44@gmail.com
            string pattern = @"^(\w+)@(\w+).([a-z]+)$";
            Console.WriteLine("Please enter your Email");
            string Userinput = Console.ReadLine().ToString();
            Match match = Regex.Match(Userinput, pattern);
            if (match.Success)
            {
                Console.WriteLine("valid Email address");
            }
            else
            {
                Console.WriteLine("not valid Email");
            }
            
        }
    }
}
