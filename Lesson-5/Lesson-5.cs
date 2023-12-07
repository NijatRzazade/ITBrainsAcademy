using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = x;
            //Console.WriteLine(x + " x");
            //Console.WriteLine(y + " y");
            //x = 20;
            //Console.WriteLine(x + " x");
            //Console.WriteLine(y + " y");

            //string a= "Salam";  //Reference type
            //string b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //a = "Sağal";
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //int[] arr = { 2, 4, 6, 7 };
            //int[] arr2 = arr;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr2[0]);
            //arr[0] = 20;
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr2[0]);

            //casting    value type arasında gedir
            //upcast and downcast
            //byte data = 20;  //upcast
            //int bigdata = data;

            //downcast data itkisi olur
            //int intdata = 300;
            //byte smalldata = (byte)intdata;
            //Console.WriteLine(smalldata);


            //double dbl = 109.5;
            //int i = (int)dbl;
            //Console.WriteLine(i);
            calculate(2.5, 2.6);
            //Console.WriteLine(Math.Ceiling(2.9999999999999));
            //Console.WriteLine(string.Equals("Salam", "SaLam"));
            //string data = "SALAM";
            //Console.WriteLine(data.ToLower());
            string data = " ";
            Console.WriteLine(string.IsNullOrEmpty(data));
        }
        public static int calculate(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine(result);
            return result;
        }
        public static double calculate(double n1, double n2)
        {
            double result = n1 + n2;
            Console.WriteLine(result);
            return result;
        }
    }
}
