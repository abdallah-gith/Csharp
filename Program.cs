using System;
using System.Collections.Generic;

namespace day4.sol
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //int[] array1 = new int[3] ;
            //int [] array2 = new int[3] {1,2,3};
            //int[] array3 = new int[] { 4, 5, 6 };
            //int[] array4 =  {6,7, 8};

            //array1 [0] = 1;
            //array1 [1] = 2;
            //array1 [2] = 3;
            //Console.WriteLine(array1[0]);
            //Console.WriteLine(array1[1]);
            //Console.WriteLine(array1[2]);//--> default is 0
            //Console.WriteLine(array1[3]);//-->OutOfRangeException 




            //int[] a1 = { 1, 2, 3 };
            //int[] a2 = { 4, 5, 6 };

            //a1 = a2;
            //Console.WriteLine(a2[1]);//5
            //a1[1] = 8;
            //Console.WriteLine(a2[1]);//8


            //a1 = (int[])a2.Clone();
            //Console.WriteLine(a2[1]);//5
            //a1[1] = 8;
            //Console.WriteLine(a2[1]);//5




            //String[,] students = new string[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter student name,subject,grade in sequence: ");
            //    for (int j = 0; j < 3; j++)
            //    {

            //        students[i, j] = Console.ReadLine();
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(students[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}




            //int[] a = { 2, 6, 1, 4, 5};
            //int[] b =new int[3] ;

            //Array.Sort(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");//1 2 4 5 6
            //}

            //Array.Reverse(a);
            //for (int f = 0; f < a.Length; f++)
            //{
            //    Console.Write(a[f] + " ");//5 4 1 6 2
            //}
            //Console.WriteLine(Array.IndexOf(a,a));

            //Array.Copy(a, b, 3);
            //for (int d = 0; d < 3; d++)
            //{
            //    Console.WriteLine(b[d] + " ");//2 6 1
            //}

            //Array.Clear(a, 3, 1);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");//2 6 1 0 5
            //}




            //int[] numbers = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("for loop:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("foreach loop:");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("while loop in reverse:");
            //int index = numbers.Length -1;
            //while (index >= 0)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index--;
            //}




            //int n;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string i = Console.ReadLine();

            //    if (int.TryParse(i, out n) && n > 0 && n % 2 != 0)
            //    {
            //        Console.WriteLine($"Correct! You entered {n}.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input");
            //    }

            //} while (true);




            //    int[,] a =
            //{
            //    { 1,  2,  3 },
            //    { 4,  5,  6 },
            //    { 7,  8,  9 }
            //};

            //    Console.WriteLine("Matrix:");
            //    for (int i = 0; i < a.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < a.GetLength(1); j++)
            //        {
            //            Console.Write(a[i, j] + "  "); 
            //        }
            //        Console.WriteLine(); 
            //    }




            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //if (month == 1) Console.WriteLine("January");
            //else if (month == 2) Console.WriteLine("February");
            //else if (month == 3) Console.WriteLine("March");
            //else if (month == 4) Console.WriteLine("April");
            //else if (month == 5) Console.WriteLine("May");
            //else if (month == 6) Console.WriteLine("June");
            //else if (month == 7) Console.WriteLine("July");
            //else if (month == 8) Console.WriteLine("August");
            //else if (month == 9) Console.WriteLine("September");
            //else if (month == 10) Console.WriteLine("October");
            //else if (month == 11) Console.WriteLine("November");
            //else if (month == 12) Console.WriteLine("December");
            //else Console.WriteLine("Invalid month number");

            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //    default: Console.WriteLine("Invalid month number"); break;
            //}












            //    int[] n = { 5, 10, 15, 20, 25 };

            //    int sumFor = 0;
            //    for (int i = 0; i < n.Length; i++)
            //    {
            //        sumFor += n[i];
            //    }
            //    Console.WriteLine($"Sum for loop: {sumFor}");

            //    int sumForeach = 0;
            //    foreach (int num in n)
            //    {
            //        sumForeach += num;
            //    }
            //    Console.WriteLine($"Sum foreach loop: {sumForeach}");








            Console.Write("Enter a number (1-7) for the day of the week: ");
            string input = Console.ReadLine();

           
            int dayn=int.Parse(input);
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayn.ToString());
                Console.WriteLine($"The day is: {day}");
    



        } }}
