using System;
using System.ComponentModel;
using System.Drawing;

namespace day2.task_.sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single line comment ->make a label or aheader for a piece of code
            //int x = 10; int y = 20;
            //int sum = x + y;
            //Console.Writeline(x + y);
            //output=30

            /*multi line comment 
             is to explain some thing
            comment never compiled*/

            /*int x = 10; int y = 20;
            int sum = x + y;
            Console.WriteLine(x + y);
            output = 30*/


            // CTRL+k+c --> comment
            // CTRL+k+u -->uncomment




            //int x = "10";
            //console.WriteLine(x + y);
            //error because y is n't defined , x is int never use "" , "Console" with capital"C" -->the fixed:
            int x = 10;
            int y = 14;
            Console.WriteLine(x + y); //24

            //pascal case
            string FullName = "Abdallah hany";
            int Age = 20;
            int Salary = 20000;
            string JobTitle = "Student";


            // Write a program to demonstrate that changing the value of a reference type affects all references pointing to that object. 
            Point p1 = new Point();
            Point p2 = new Point();
            Console.WriteLine(p1.X);//0
            Console.WriteLine(p2.X);//0
            p1.X = 7;
            p2 = p1;
            Console.WriteLine(p1.X);//7
            Console.WriteLine(p2.X);//7



            //Create a program that calculates the following using variables x = 15 and y = 4: 
            double x = 15;
            double y = 4;
            double sum = x + y;
            double difference = x - y;
            double product = x * y;
            double division = x / y;
            double remainder = x % y;
            Console.WriteLine(sum);//19
            Console.WriteLine(difference);//11
            Console.WriteLine(product);//60
            Console.WriteLine(division);//3.75
            Console.WriteLine(remainder);//3


            //What will be the output of the following code? Explain why: 

            int a = 2, b = 7;
            Console.WriteLine(a % b);//2
            //beacause 2<7 so it is the remainder



            // Write a program that checks if a given number is both
            int x;
            Console.WriteLine("Enter the numer: ");
            string v = Console.ReadLine();
            x = int.Parse(v);
            if (x > 10) { Console.WriteLine("The number is greater than 10 "); }
            else { Console.WriteLine("the number is less than 10"); }

            //if (x % 2 == 0) { Console.WriteLine("The number is even"); }
            //else { Console.WriteLine("the number is odd"); }

            //impicit
            double x = 112.12;
            int z = 10;
            x = z;
            Console.WriteLine(x);
            //explicit
            double y = 2002.45;
            checked
            {
                y = (int)y;
            }
            Console.WriteLine(y);


            //Prompts the user for their age as a string.
            //Converts the string to an integer using Parse. 

            Console.WriteLine("Enter your age");
            string v = Console.ReadLine();
            int age = int.Parse(v);
            if (age > 0)
            {
                Console.WriteLine("Valid");
            }


           // Write a program that demonstrates the difference between prefix and postfix increment operators using a variable x.
            int x = 5;
            Console.WriteLine(x);//5
            Console.WriteLine(x++);//5
            Console.WriteLine(x);//6
            Console.WriteLine(++x);//7
            Console.WriteLine(x);//7


            int x = 5;
            int y = ++x + x++;
            Console.WriteLine(x);//7








        }
    }
}

