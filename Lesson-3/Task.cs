using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };
            //1) Yuxaridaki arrayda 5 reqeminin nece defe tekrarlandigini tapin
            //2) Yuxaridaki arraydaki butun reqemlerin cemini tapin
            //3) arraydaki en boyuk reqemi tapin ve nece defe tekrarlandigini gosterin
            //4)arraydaki ilk 3 e bolunende qaliqda 2 alinan reqemi ve hemin reqemin arraydaki indexini tapin
            //5)arraydaki en boyuk reqemin ilk indexini tapin
            //6)4 reqeminin arrayin hansi indexlerinde oldugunu gosterin
            //7)5 reqeminin arraydaki en boyuk ve en kicik indexlerini tapin

            //1
            //int a = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (5 == array[i])
            //    {
            //        a++;
            //    }
            //}
            //Console.WriteLine("Arrayda 5 Ededi : " + a + " Defe tekrar edilir");
            //Console.ReadLine();


            //2
            //int sum = 0;
            //foreach (var item in array)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();


            //3
            //int Max = array[0];
            //foreach (var item in array)
            //{
            //    if (item > Max)
            //    {
            //        Max = item;
            //    }
            //    int a = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (7 == array[i])
            //        {
            //            a++;
            //        }
            //    }
            //    Console.WriteLine("Arrayda 7 Ededi : " + a + " Defe tekrar edilir");
            //    Console.ReadLine();
            //}
            //Console.WriteLine(Max);
            //Console.ReadLine();


            //4
            //int x = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 3 == 2)
            //    {
            //        Console.WriteLine(array[i]);
            //        x++;
            //        Console.ReadLine();
            //    }
            //    if (x == 3)
            //    {
            //        break;
            //        Console.ReadLine();
            //    }
            //}



            //5
            //int Max = array[0];
            //foreach (var item in array)
            //{
            //    if (item > Max)
            //    {
            //        Max = item;
            //    }
            //}
            //Console.WriteLine(Max);
            //Console.WriteLine(array[Max] + " indexi " +  Max);
            //Console.ReadLine();

            //7
            //int count = 0;
            //int[] arr = new int[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == 5)
            //    {
            //        count++;
            //        Array.Resize(ref array, count);
            //        array[count - 1] = i;
            //    }
            //}
            //Console.WriteLine("min " + array[0]);
            //Console.WriteLine("max " + array[array.Length - 1]);
        }
    }
}

