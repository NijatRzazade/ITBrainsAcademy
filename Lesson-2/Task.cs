using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = Convert.ToInt32(Console.ReadLine());
            switch (grade)
            {
                case int g when (g >= 90 && g <= 100):
                    Console.WriteLine($"Grade: {grade} - Letter Grade: A");
                    Console.ReadLine();
                    break;
                case int g when (g >= 80 && g <= 89):
                    Console.WriteLine($"Grade: {grade} - Letter Grade: B");
                    Console.ReadLine();
                    break;
                case int g when (g >= 70 && g <= 79):
                    Console.WriteLine($"Grade: {grade} - Letter Grade: C");
                    Console.ReadLine();
                    break;
                case int g when (g >= 60 && g <= 69):
                    Console.WriteLine($"Grade: {grade} - Letter Grade: D");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine($"Grade: {grade} - Letter Grade: F");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
