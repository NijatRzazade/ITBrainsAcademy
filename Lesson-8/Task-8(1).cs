using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Dictionary<string,string>dictionary=new Dictionary<string,string>();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ölke adı daxil edin: ");
                string country=Console.ReadLine();

                Console.WriteLine("Paytaxt adı daxil edin: ");
                string capital=Console.ReadLine();

                dictionary.Add(country, capital);
            }

            foreach(var item in dictionary)
            {
                Console.WriteLine("Zehmet olmasa paytaxtını tapmaq istediyiniz ölkenin adını daxil edin: ");
                string input = Console.ReadLine();
                if (item.Key == input)
                {
                    Console.WriteLine($"Paytaxt: {item.Value}");
                }
                if (input == "all")
                {
                    Console.WriteLine($"Ölke: {item.Key} Paytaxt:{item.Value}");
                }
                Console.WriteLine("Yeni paytaxt adı axtarılsın? Y/N");
                string option = Console.ReadLine();
                if(option == "Y")
                {
                    continue;
                }
                if(option == "N")
                {
                    break;
                }
            }
        }
    }
}

