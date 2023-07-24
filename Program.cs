using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    internal class Program
    {
        /*      TASK 1
         * 
         * 
         * static void Main(string[] args)
         {
             Console.WriteLine("Hello, world");
         }*/

        /*    TASK  2
         * 
         * static void Main(string[] args)
         {
             Console.WriteLine("Enter your name?");
             string name = Console.ReadLine();
             Console.WriteLine($"Hello ,{name}" );
         }*/

        /*      TASK 3
         * 
         * static void Main(string[] args)
          {
            *//*  Console.WriteLine("Enter First Number");
              int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Second Number");
              int b = int.Parse(Console.ReadLine());
              int sum = a + b;
              int subtraction = a - b;
              int multiply = a * b;
              double division = a / b;
              double mdivision = a % b;
              Console.WriteLine($" sum is: { sum}" );
              Console.WriteLine($"subtraction is : {subtraction}");
              Console.WriteLine($"multiplication is : {multiply}");
              Console.WriteLine($"division is : {division}");
              Console.WriteLine($"mdivision : {mdivision} ");
              Console.ReadKey();*//*

          }*/

        /*        TASK 4
         *  
         *  static void Main(string[] args)
          {
              Console.WriteLine("Enter a Num to Know weather it is even or odd");
              int a = int.Parse(Console.ReadLine());
              if (a % 2 == 0)
              {
                  Console.WriteLine("Its even");
              }
              else
              {
                  Console.WriteLine("Its odd");
              }
              Console.ReadKey();
          }*/




        /*   Task 5    
       static void Main(string[] args)
       {
           *//* for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*//*
           int i=1;
          while( i<=10)
           {
               Console.WriteLine(i);
               i++;

           }
          Console.ReadKey();
       }*/



        /*            TASK 6
         * 
         * static void Main(string[] args)
         {
             int[] list = { 1, 2, 3, 4, 5 };
             int sum = 0;
             foreach (int i in list)
             {
                 sum += i;
             }
             int avg = sum/ list.Length;
             Console.WriteLine($" sum is {sum}");
             Console.WriteLine($" avg is {avg}");
             Console.ReadKey();
         }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);


        }
    }
}
