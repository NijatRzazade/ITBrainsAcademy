using System;
using System.Collections;  //ArrayList
using System.Collections.Generic;  //List
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boxing vs Unboxing
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(15);
            //arrayList.Add("gfgf");
            //var telebe = new { name = "Ncat", surname = "Rzazade", age = 20 };
            //boxing and unboxing
            //boxing value  ==> referance
            //int x = (int)arrayList[1];*/   //uboxing
            // int   // obj
            //int x1 = 20;
            //object num = 15;   //boxing

            //if(arrayList[0] is int)
            //{
            //    int x = (int)arrayList[0];
            //}

            //int[] arr = { 2, 3, 4, 5, 6 };
            //int y = arr[1];
            #endregion


            // normal
            //int x = 25;   //variable deyisen
            //Console.WriteLine(x);
            //ChangeNum(x);
            //Console.WriteLine(x);

            // ref
            //int x = 25;
            //Console.WriteLine(x);
            //ChangeNum(ref x);
            //Console.WriteLine(x);

            //int[] arr = { 1, 2, 3, 4, 5};
            //ChangeNum(ref arr[1]); 

            // out
            //int x;
            //ChangeNum(out x);
            //Console.WriteLine(x);

            List<int>list=new List<int>();
            //ArrayList arrayList = new ArrayList();
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            list.Add(1);
            list.Add(5);
            list.Add(35);
            list.Add(45);
            list.Remove(35);     //prize del
            list.RemoveAt(0);    //index del
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }

        //public static void ChangeNum(out int number)  //parametr
        //{
        //    number = 20;
        //}
    }
}
