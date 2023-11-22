using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //+,-,*,/
            Console.WriteLine("1-ci ededi daxil et");
            float x1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2-ci ededi daxil et");
            float x2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("symbol daxil et");
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    Console.WriteLine("Result :" + (x1 + x2));
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine("Result :" + (x1 - x2));
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine("Result :" + x1 * x2);
                    Console.ReadLine();
                    break;
                case "/":
                    Console.WriteLine("Result :" + x1 / x2);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Duzgun simbol daxil edilmeyib");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
