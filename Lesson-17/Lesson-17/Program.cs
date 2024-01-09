using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    internal class Program
    {
        public delegate bool Checkers(int a); // Delegate
        public delegate void Writer(int n);
        static void Main(string[] args)
        {

            //int[] newArr = { 5, 7, 9 };
            //Sum(5,7,9);


            //Sum(IsEven, 2, 4, 5, 8, 9, 12, 36, 45);
            //Sum(IsOdD, 3, 5, 8, 9, 12, 48);
            //Sum(DivideBy4, 3, 5, 6, 4, 8, 9, 15, 28);



            //WriterEven(18);
            //WriterElder(18);
            //WriterDivisible(18);

            Writer writer = new Writer(WriterEven);
            writer += WriterElder;
            writer += WriterDivisible;
            writer(18);

        }

        #region Params
        //public static void Sum(params int[] arr)

        //{
        //    var total = 0;
        //    foreach (var item in arr)
        //    {
        //        total += item;
        //    }
        //    Console.WriteLine(total);
        //}
        #endregion


        static bool IsEven(int a) => a % 2 == 0;  // Lambda expression 
        static bool IsOdD(int a)
        {
            return a % 2 == 1;
        }
        static bool DivideBy4(int a)
        {
            return a % 4 == 0;
        }
        static int Sum(Checkers check ,params int[] numbers)
        {
            int sum = 0;

            foreach(var item in numbers)
            {
                if (check(item))
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
            return sum;
        }



        static void WriterEven(int n)
        {
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            Console.WriteLine((n % 2 == 0 ? "even" : "odd")); // Ternary operator
        }
        static void WriterElder(int n)
        {
            Console.WriteLine($"Number {n} is {(n >= 18 ? "elde" : "baby")}");
        }
        static void WriterDivisible(int n)
        {
            Console.WriteLine($"Number {n} is {(n % 3 == 0 ? "dvisible by 3" : "not divisible 3")}");
        }
    }
}
