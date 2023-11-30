using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //string data = "salam";
            //Console.WriteLine(data.Contains("sa"));
            //IsNullOrEmpty(data);

            //2
            //string A = "Hello word";
            //string B = "Hello word";
            //Console.WriteLine(A, B);
            //Equals(A, B);

            //3
            //string x = "student";
            //GetLength(x);
        }
        //1 IsNullOrEmpty nin algoritmi
        public static void IsNullOrEmpty(string data)
        {
            if (data.Length == 0)    
            {
                Console.WriteLine("nulldir");
            }
            else
            {
                Console.WriteLine("null deyil");
            }
        }
        //2 String Equals methodu kimi method yazmaq algoritmini
        public static void Equals(string A, string B)
        {
            if(A==B)   //if(A.ToLower().Trim()==B.ToLower().Trim())
            {
                Console.WriteLine("Beraberdir");
            }
            else
            {
                Console.WriteLine("Beraber deyil");
            }
        }
        //3 Length in algoritmini method seklinde yaz
        public static void GetLength(string word)
        {
            int count = 0;
            foreach(var item in word)
            {
                count++;
            }
            Console.WriteLine("Length: " +count);
        }
    }
}
