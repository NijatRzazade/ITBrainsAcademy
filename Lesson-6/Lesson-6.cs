using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fin = "AZE00854688";
            //Console.WriteLine(fin.Substring(3,3));
            //Console.WriteLine(fin.IndexOf('Z'));
            //string str = "Hello word";
            //Console.WriteLine(str.Replace('w', 'v'));       Console.WriteLine(str.Replace("Hello","Hi"));
            //string str = "Hello word student";
            //string[] arr = str.Split(' ');
            //string tt = "Hello word";
            //string tt2 = "Student";
            //Console.WriteLine(string.Concat(tt, " ", tt2, " dhdskdjkad"));
            //Console.WriteLine( tt + " "+  tt2+ " sgdgggsss");

            string[] arr = { "BMW", "Mercedes", "Audi" };
            ArrayList arrayList=new ArrayList();
            arrayList.Add("TT");
            arrayList.Add(5);
            arrayList.Add(5.60);
            arrayList.Add(arr);
            arrayList.Remove(5);
        }
    }
}
