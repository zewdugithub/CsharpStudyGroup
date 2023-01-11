using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YosephExampleRepractice
{

    public class Program
    {
        public static void Main(string[] args)
        {

            //===>Variales  assignment
            /*int num1;
               int num2;

              string FName, LName;
              FName = "Zewdu";
              LName = " Tsegaye";
              bool num1lessnum2;
              num1 = 12;
              num2 = 13;
              if (num1 < num2) num1lessnum2 = true;
              else num1lessnum2 = false;
              Console.WriteLine(" is num1 less than num2? " + num1lessnum2);
              Console.WriteLine(" Your Name is {0}", FName + " " + LName);
              Console.ReadLine();
               */

            //====>write a program to check if a word is a palindrome or not
            //(Example ATOYOTA) is a plaindrome(you can read from left and right the same.

            //String string1 = "ATOYOTA";
            //Boolean flag = true;

            ////Converts the given string into lowercase to make sure all the characters are in the same order.
            //string1 = string1.ToLower();

            /* //Iterate the string forward and backward, compare one character at a time
            // till middle of the string is reached
              for (int i = 0; i < string1.Length / 2; i++)
             {
                 if (string1[i] != string1[string1.Length - i - 1])     //[i] a, t,o,y,o,t,a
                 {
                     flag = false;
                     break;
                 }
             }
             if (flag)
                 Console.WriteLine("Given string is palindrome");
             else
                 Console.WriteLine("Given string is not a palindrome");
                 Console.ReadLine();
             */
            /*Console.WriteLine(" Please enter your word here to check if it is a palindrome.");
            String string1 = Console.ReadLine().ToString();
            //String string1 = "ATOYOTA";
            Boolean flag = true;
            //Converts the given string into lowercase to make sure all the characters are in the same order.
            string1 = string1.ToLower();        //string1 = atoyota
                                                //Iterate the string forward and backward, compare one character at a time
                                                // till middle of the string is reached
            for (int i = 0; i < string1.Length / 2; i++)
            //String1 = atoyota , String1.Length = 7 ( a, t, o, y ,o, t, a)
            // String1.Length / 2 =  7 /2 = 3.5 ( the 4th character in String)= y 
            // Values of i = 0, 1, 2 ( only upto the 3rd character of the string {-a-t-o} )
            // for ( start at 0, max - 2r, increase by/count 1
            //[i]-  a,t,o,y,o,t,a   place value - 0 = 1st letter
            //to iterate a reverse order in array - use "String.Length - 1"
            {
                if (string1[i] != string1[string1.Length - i - 1])
                //string1[0] = a
                //string1[string.Length(7) - i(0) -1 = 7 -0 -1 = 6]= string1[6] = a
                //a != a  - false
                //[i]-  a,t,o,y,o,t,a   place value - 0 = 1st letter
                //to iterate a reverse order in array - use "String.Length - 1"
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                Console.WriteLine("Given string is palindrome");
            else
                Console.WriteLine("Given string is not a palindrome");
            Console.ReadLine();
            */

            //Console.WriteLine(" please enter the word");
            //string srt= Console.ReadLine() .ToString();
            //char[] array = srt.ToCharArray();
            //int length = array.Length - 1;
            //Boolean palindrome = true;
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write(palindrome = false);
            //    Console.WriteLine(" your word is palindrome");
            //    break;
            //}
            //if (palindrome) ;
            //{
            //    Console.WriteLine("your word is a palindrome");
            //    Console.ReadLine();
            //}
            //else
            // Console.WriteLine(length--);


            /*int num1;
              int num2;
              int sum;
              Console.WriteLine(" enter the first Number");
              num1 = int.Parse(Console.ReadLine());
              Console.WriteLine(" please enter the second Number");
              num2= int.Parse(Console.ReadLine());
              sum=num1+ num2;
              Console.WriteLine("The sum is {0}", sum);

              Console.ReadLine();
            */
            // ====>how to use constat variable.
            /*const double plastic = 0.10;
            int amount;
            Console.WriteLine(" please enter the amount");
            amount=int.Parse(Console.ReadLine());
            Console.WriteLine(" The final amount is {0}", amount + plastic);
            Console.ReadLine();
            */
            //=====> how to  assign variable. to do arthimetic relational and logical operations.
            /*
            int a;
            int b;  
            int c;
            int d;
            Console.WriteLine(" enter the first Number");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second Number");
            b=int.Parse(Console.ReadLine());
            c = a + b;
           //b++;
            Console.WriteLine("  The first number is {0}, the second number is {1}, result is {2}",a,b,c);
           d=a%b;
            Console.WriteLine("  The first number is {0}, the second number is {1}, modulo is {2}",a,b,d);
           Console.WriteLine(" Is number 1 equal to num2? {0}",a==b);
           Console.WriteLine(" Is num1 greater than 12 or num2 is less than 8 {0}",a>12||b<8);
          Console.WriteLine("  num1 greater than 12 and num2 is less than 8 {0}",a>12 && b<8);

           Console.WriteLine("  is num1 not equal to num2 {0}", a != b);

           Console.ReadLine();
          */
            //====> HOW TO CREAT METHODS
            //Grade g= new Grade();
            //Console.WriteLine(" the grade is {0}", g.GetGrade(79));
            //Console.ReadLine();

            /*Student s= new Student();
            s.Fname = "Zewdu";
            Console.WriteLine("First Name of the student is {0}", s.Fname);
            Console.ReadLine();
            */
            //Student g =new Student();

            //g.Name = " zewdu";
            //g.Name = " lema";
            //Console.WriteLine(" the first name of student is{0}" , g.Name);


            //Student s = new Student(); // ex for automatic
            //s.myName = "Tsegaye";
            //Console.WriteLine( " my name is {0}" ,s.myName);


            //Console.WriteLine(" the full name is {0}", s.FullName);
            //Console.ReadLine();

            //=======> 
            //Account acc= new Account();

            //  //acc.IntialAmout = 1000;
            // Console.WriteLine("  the intitial amount is  " +  acc.IntialAmout); //b/c it take the class name not the property name.

            // Console.ReadLine();
            //Person p = new Person("Test", "Tes2", "123-45-500");   
            ////p.fName = "Test";
            ////p.lName= "Tes2";
            ////p.SSN = "123-45-500";
            //Console.WriteLine(" The person info is ", p.GetPerson());
            //Console.ReadLine();

           // Console.WriteLine(" Hello\tworld\n\n Addis\n\n Ababa");
            
            
            
            
            Console.ReadLine();

            
                 


}

    
    }
}
