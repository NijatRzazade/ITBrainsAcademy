using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sort = new SortedList<int, string>();
            byte a = 0;
            while (true)
            {
                a++;
                Console.WriteLine("Enter the number: ");
                int Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the written from of the number you entered");
                string Num2 = Console.ReadLine();
                int b = Num1;
                sort.Add(Num1, Num2);
                if (a == 5)
                {
                    break;
                }
            }
            foreach(var item in sort.Keys)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
