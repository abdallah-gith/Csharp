using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace day3.sol
{
    internal class Program
    {

        class Animal
        {
            public string Name;
        }
        static void Main(string[] args)
        {



            //(CTRL + / )--> comment / uncomment

            string v = Console.ReadLine();
            try
            {
                int x = int.Parse(v);
                int y = Convert.ToInt32(v);
                Console.WriteLine(v);
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }



            string v = Console.ReadLine();
            bool x = int.TryParse(v, out int y);
            if (y == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(y);
            }





            object obj1 = new object();
            object obj2 = new object();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());
            obj1 = "Ali";
            Console.WriteLine(obj1);
            obj1 = 2;
            Console.WriteLine(obj1);
            obj1 = 2.5;
            Console.WriteLine(obj1);
            obj2 = obj1;
            Console.WriteLine(obj2);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());





            Animal a1 = new Animal();
            Animal a2 = new Animal();
            a1.Name = "Cat";
            a2 = a1;
            Console.WriteLine(a1.Name);
            Console.WriteLine(a2.Name);






            String x = "I'm Abdallah";
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(x + " Hi Willy");
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine($"{x} Hi willy");
            Console.WriteLine(x.GetHashCode());
            x += " Hi Willy";
            Console.WriteLine(x);
            Console.WriteLine(x.GetHashCode());





            StringBuilder x = new StringBuilder("Hey");
            Console.WriteLine(x);
            Console.WriteLine(x.GetHashCode());
            x.Append(" Hi Willy");
            Console.WriteLine(x);
            Console.WriteLine(x.GetHashCode());







            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum is " + x + "+" + y + "=" + (x + y));
            Console.WriteLine(string.Format("Sum is {0}+{1}={2}", x, y, (x + y)));
            Console.WriteLine($"Sum is {x}+{y}={x + y}");






            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb.Append("World"));
            Console.WriteLine(sb.Replace("ld", "y"));
            Console.WriteLine(sb.Insert(0, "go "));
            Console.WriteLine(sb.Remove(0, 2));






        }
    }
}
