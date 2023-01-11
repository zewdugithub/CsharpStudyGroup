using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)


        {

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Write(i +" , ");

            //}
            //Console.ReadLine();

            /* Write a C# Sharp program that takes a number as input and print its
            multiplication table
            o Test Data:
            Enter the number: 5
            Expected Output:
            5 * 0 = 0
            5 * 1 = 5
            5 * 2 = 10
            5 * 3 = 15....5 * 10 = 50
            */

            //int num1;
            //int num2;
            //int result;
            //Console.WriteLine(" please enter the first number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(" please enter the second number");
            //num2 = int.Parse(Console.ReadLine());

            //result = num1 * num2;
            //Console.WriteLine(" The result is {0}", result);
            //Console.WriteLine ();
            //Console.ReadLine();

            /*
             Write a C# Sharp program that takes a number and a width also a
            number, as input and then displays a triangle of that width, using
            that number.
            Test Data
            Enter a number: 6
            Enter the desired width: 6
            Expected Output :
            666666
            66666
            6666
            666
            66
            6 */

            //for (int w = 6; w >0; w--)

            //{ for (int j = 0; j < w; j++)
            //    {
            //        Console.Write("6");
            //    }

            //   Console.WriteLine();

            //}
            //console= Console.ReadLine();

            //  Q 5write a program to revert yor name?

            /* string inputsting = " zewdu";
               string resultString=string.Join(" ", inputsting.Split(' ').Select(x=>new String(x.Reverse() .ToArray())));
               Console.WriteLine(resultString);    
               Console.ReadLine(); 
            */
            // Q 6 write a program to convert your name into upper case?


            /* Console.WriteLine("please Write your name");
             string mulu= (Console.ReadLine().ToString().ToUpper());
             Console.WriteLine(mulu);
             Console.ReadLine();
             */
            //Q 7 write a program to count number of characters in your name

            /*   String string1 = "Zewdu";
               int count = 0;

               //Counts each character except space  
               for (int i = 0; i < string1.Length; i++)
               {
                   if (string1[i] != ' ')
                       count++;
               }

               //Displays the total number of characters present in the given string  
               Console.WriteLine(" Zewdu " + count);
               Console.ReadLine()

              or====>

            Console.WriteLine("Please Enter your Name");
              string UserName = Console.ReadLine().ToString();
              int ct = 0;
              for (int i = 0; i < UserName.Length; i++)
              {
                  //if (UserName[i] != ' ')
                  ct++;
                  //ct =i+1;
                  //ct++; 
              }
              Console.WriteLine(UserName + " " + ct);
              Console.ReadLine();
            */
            // Q 8 write a program to check if the number is prime or not

            /*  int n, i, m = 0, flag = 0;
              Console.Write("Enter the Number to check Prime: ");
              n = int.Parse(Console.ReadLine());
              m = n / 2;
              for (i = 2; i <= m; i++)
              {
                  if (n % i == 0)
                  {
                      Console.Write("Number is not Prime.");
                      flag = 1;
                      break;
                  }
              }
              if (flag == 0)
                  Console.Write("Number is Prime.");
              Console.ReadLine();
             */


            // Q 9  write a program to access age of student and categoriz as followes
            // if age is <= 12 kid
            // if age>=13 and <=19 teen
            // if age >19 adult

            // declare variables
            /*     double age;

                 // take input
                 Console.Write("Enter the age: ");
                 age = Convert.ToDouble(Console.ReadLine());

                 // find the age
                 if (age <= 0)
                     Console.WriteLine("Invalid age!");
                 else if (age < 2)
                     Console.WriteLine("Age group: Baby");
                 else if (age < 13)
                     Console.WriteLine("Age group: Child");
                 else if (age < 18)
                     Console.WriteLine("Age group: Adolescent");
                 else if (age < 60)
                     Console.WriteLine("Age group: Adult");
                 else
                     Console.WriteLine("Age group: Old");

             // wait for user to press any key
                     Console.ReadLine(); 
              */
            // Q 10  Write a program to accept gender in single character
            // as M or F and display in full as Famale or Male


            ////  char gender;

            ////  //Reading gender from user
            ////  Console.WriteLine("Enter gender (M/m or F/f): ");
            ////  gender = Convert.ToChar(Console.ReadLine());


            ////  // checking vowel and consonant
            ////   switch (gender)
            ////  {
            ////      case 'M':
            ////      case 'm':
            ////          Console.WriteLine("MALE");
            ////          break;

            ////      case 'F':
            ////      case 'f':
            ////          Console.WriteLine("FEMALE");
            ////          break;

            ////      default:
            ////          Console.WriteLine("Unspecified Gender");
            ////          break;
            ////  }

            ////  Console.ReadLine();


            ////  Q 12 write a program to check if a word is a palindrome or not
            ////  (Example ATOYOTA) is a plaindrome( you can read from left and right the same.

            ////  String string1 = "ATOYOTA";
            ////  Boolean flag = true;

            ////  Converts the given string into lowercase  to make sure all the characters are in the same order.
            ////  string1 = string1.ToLower();

            ////  Iterate the string forward and backward, compare one character at a time   
            ////  till middle of the string is reached  
            ////  for (int i = 0; i < string1.Length / 2; i++)
            ////  {
            ////      if (string1[i] != string1[string1.Length - i - 1])
            ////      {
            ////          flag = false;
            ////          break;
            ////      }
            ////  }
            ////  if (flag)
            ////      Console.WriteLine("Given string is palindrome");
            ////  else
            ////      Console.WriteLine("Given string is not a palindrome");
            ////       Console.ReadLine();

            ////   //Q 14 Write a C# sharp program to print Hello and your Name in separate line

            //Console.WriteLine("Hello");
            //Console.WriteLine("Zewdu");
            //Console.ReadLine();

            //Console.Write("What is your first name? ");
            //string fname = Console.ReadLine();

            //Console.Write("What is your last name? ");
            //string lname = Console.ReadLine();

            //Console.WriteLine("Hello:\n {0} {1}", fname, lname);
            //Console.ReadLine();

            //////  Console.ReadLine();
            //Console.WriteLine("What is your Name?");
            //string userInput = Console.ReadLine().ToString();
            //Console.WriteLine("Hello \n {0} ", userInput);

            // Q 15 write a C# Sharp program to print the sum of two numbers.

            ////  int num1;
            ////  int num2;
            ////  int result;
            ////  Console.WriteLine(" write the first Number");
            ////  num1 = int.Parse(Console.ReadLine());
            ////  Console.WriteLine(" write the second Number");
            ////  num2= int.Parse(Console.ReadLine());
            ////  result=num1 + num2;
            ////  Console.WriteLine(result);
            ////  Console.ReadLine();


            //// // Q 16 write a c# Sharp program to swap two numbers.
            //// // example num1=5,num2=6 and after swapping num1=6 ,num2=5


            //// int a = 5, b = 10;
            ////  Console.WriteLine("Before swap a= " + a + " b= " + b);
            ////  a = a + b; //a=15 (5+10)      
            ////  b = a - b; //b=5 (15-10)      
            ////  a = a - b; //a=10 (15-5)   
            ////  Console.Write("After swap a= " + a + " b= " + b);
            ////  Console.ReadLine();


            //// //Q 17  write a c# Sharp program to print the output of multiplication of
            //// //three numbers which will be entered by the user.

            //// /*  int num1;
            ////   int num2;   
            ////   int num3;
            ////   int result;
            ////   Console.WriteLine("write the fist number");
            ////   num1= int.Parse(Console.ReadLine());
            ////   Console.WriteLine("write the second number");
            ////   num2= int.Parse(Console.ReadLine());
            ////   Console.WriteLine("write the third number");
            ////   num3= int.Parse(Console.ReadLine());
            ////   result=num1*num2*num3;
            ////   Console.WriteLine(" the result is  " + result);
            ////   Console.ReadLine();
            ////  */
            //// // Q 18  write a C# Sharp program to print on
            //// // screen the output of adding, subtracting, multiplying
            //// // and dividing of two numbers which will be entered by the user.

            //  Console.Write("Enter a number: ");
            // int num1 = Convert.ToInt32(Console.ReadLine());

            //  Console.Write("Enter another number: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            // Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            // Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            // try
            // {
            //     Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            // }
            // catch (DivideByZeroException e)
            // {
            //     Console.WriteLine("the second number can't be zero ,please enter another number");
            //     Console.ReadLine();

            ////*/
            //// // Q 19 write a c# Sharp progarm that takes a number as input and
            //// // print its multiplication table.

            //// /*  int x;
            ////   int result;

            ////   Console.WriteLine("Enter a number:");
            ////   x = Convert.ToInt32(Console.ReadLine());
            ////   result = x * 1;
            ////   Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
            ////   result = x * 2;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
            ////   result = x * 3;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
            ////   result = x * 4;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
            ////   result = x * 5;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
            ////   result = x * 6;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
            ////   result = x * 7;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
            ////   result = x * 8;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
            ////   result = x * 9;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
            ////   result = x * 10;
            ////   Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
            ////   Console.ReadLine();

            ////   */
            //// // Q 20 Write a c# Sharp program that takes a number and a width also
            //// // a number, as input and then displays a tringle of that width,
            //// // using that number.

            //// /* Console.Write("Input a number: ");
            ////  int num = Convert.ToInt32(Console.ReadLine());

            ////  Console.Write("Input the desired width: ");
            ////  int width = Convert.ToInt32(Console.ReadLine());

            ////  int height = width;
            ////  for (int row = 0; row < height; row++)
            ////  {
            ////      for (int column = 0; column < width; column++)
            ////      {
            ////          Console.Write(num);
            ////      }

            ////      Console.WriteLine();
            ////      {
            ////          width--;
            ////      }

            ////      Console.ReadLine();

            ////    }
            ////    */

            //// // Q 21 write a c# sharp program tha takes two numbers as
            //// // input and perform an operation (+,-,*,x,/) on them and
            //// // displays the result of that operation.

            //// /*int x, y;
            //// char operation;

            //// Console.Write("Input first number: ");
            //// x = Convert.ToInt32(Console.ReadLine());
            //// Console.Write("Input operation: ");
            //// operation = Convert.ToChar(Console.ReadLine());
            //// Console.Write("Input second number: ");
            //// y = Convert.ToInt32(Console.ReadLine());

            //// if (operation == '+')
            ////     Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            //// else if (operation == '-')
            ////     Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            //// else if ((operation == 'x') || (operation == '*'))
            ////     Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            //// else if (operation == '/')
            ////     Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            //// else
            ////     Console.WriteLine("Wrong Character");
            //// Console.ReadLine();
            //// */


            //// // Q 22 write a C# sharp progarm that takes the radius of a circle
            //// // as input and calculate the primeter and area of the circle.

            //double r, per_cir, area;
            //double PI = 3.14;
            //Console.WriteLine("Input the radius of the circle : ");
            //r = Convert.ToDouble(Console.ReadLine());
            //per_cir = 2 * PI * r;
            //Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            //area = PI * r * r;
            //Console.WriteLine("area of the circle is  {0}", area);
            // Console.Read();


            //// // Q 23 write a C# Sharp program tha takes distace and time as input
            //// // and displays the speed in kilometers per hour and miles per hour.
            //// /*
            ////   float distance;
            ////   float hour, min, sec;

            ////   float timeSec;
            ////   float mps;
            ////   float kph, mph;

            //   Console.Write("Input distance(metres): ");
            //   distance = Convert.ToSingle(Console.ReadLine());
            //   Console.Write("Input timeSec(hour): ");
            //   hour = Convert.ToSingle(Console.ReadLine());
            //   Console.Write("Input timeSec(minutes): ");
            //   min = Convert.ToSingle(Console.ReadLine());
            //   Console.Write("Input timeSec(seconds): ");
            //   sec = Convert.ToSingle(Console.ReadLine());

            //   timeSec = (hour * 3600) + (min * 60) + sec;
            //   mps = distance / timeSec;
            //   kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            //   mph = kph / 1.609f;

            //   Console.WriteLine("Your speed in metres/sec is {0}", mps);
            //   Console.WriteLine("Your speed in km/h is {0}", kph);
            //   Console.WriteLine("Your speed in miles/h is {0}", mph);
            //   Console.ReadLine();  
            // */

            //Q 24  write a C# Sharp program that takes a character as input and check the
            //iput (Lowercase) is a vowel,a digit, or any other symbol.

            /*char symbol;

            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                   Console.WriteLine("It's a digit.");
            else
            Console.Write("It's another symbol.");
            Console.ReadLine();
            */

            //// //Q 25 Write a C# Sharp program that takes two numbers as input
            //// //and returns true or false when both numbers are even or odd.

            //int n1, n2;
            //bool bothEven;
            //Console.Write("Input First number: ");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input Second number: ");
            //n2 = Convert.ToInt32(Console.ReadLine());


            //bothEven = ((n1%2!=0) || (n2%2!=0))? false:true;
            //bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true:false;

            // Console.WriteLine(bothEven ?
            //  "there're numbers bothEven":"there's a number odd");
            //   Console.ReadLine();


            //// //Q 8 write a program to check if the number is prime or not

            ////  Console.WriteLine("Enter a number to check if it's a Prime or not");
            ////  //Prine - divisible by 1 and itself only- has only 2 factors {1,itself}
            ////  //Compoisite - has more than 2 factors( 1, number itself and  more. Eg - 9 is composite because its factors are { 1, 3, 9}
            ////  int a = 0;
            ////  int n = Convert.ToInt32(Console.ReadLine()); //21 factor{ 1,3,7,21}
            ////                                               //int n = int.parse(Console.ReadLine()); 
            ////  for (int i = 1; i <= n; i++)
            ////  //1 -21 = 1,2,3,4,5,...21
            ////  //int i can't be 0 because any number can't be divided by 0- undefined- math rule!
            ////  // int i should always start with 1 because all numbers are divided by 1 whether prime or composite( not prime).
            ////  {
            ////      if (n % i == 0)      //n= 21, i = 1, n%i = 21 % 1 = 0
            ////      {
            ////          a++;    // here the if statement will be true for i = 1,3,7,21  
            ////      }
            ////      // when the if statement is true- the loop will run  and it will display the result as the number of true loops.
            ////      // (loops it ran) it became true as the result= int a in our case.   
            ////  }
            ////  if (a ==2)
            ////  // a represents how many  times the true loop ran - in this specific case; when the if( n%i == 0) was true only.
            ////  // It does not register when the if case was false but continiues to run the next loop.
            ////  // if iniital a value is not 0 ( int a !=0 )- we should always make sure the {if (a == ' ') } statement a
            ////  // value is +2( 2 numbers more than a value) at all time 
            ////  {
            ////      Console.WriteLine("is a Prime Number", n);
            ////  }
            ////  else
            ////  {
            ////      Console.WriteLine("Not a Prime Number");
            ////  }
            ////   Console.ReadLine();


            // how array and loops work forward and backward
            //int[] grade = { 55, 66, 78, 48, 69 };
            //for (int i = 0; i < grade.Length; i++)    //this is forward loop in the array.
            //  {
            //   grade[i] +=3;
            //    Console.WriteLine(grade[i]);
            //  }
            //Console.ReadLine() ;

            //int[] grade = { 55, 66, 78, 48, 69 };
            //for (int i=grade.Length - 1; i >= 0; i--) //this is backward loop in the array.
            //  {
            //    grade[i] += 3;
            //    Console.WriteLine(grade[i]);
            //}
            // Console.ReadLine();


           


        }

    }
    
}


    
    

