using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region S.Collection
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("sdsfsfsf");
            ////Console.WriteLine(arrayList[0]);
            //arrayList.Add(2.9);
            //arrayList.Remove(1);    // 1 del
            //arrayList.RemoveAt(0);  // sdsfsfsf del
            //Console.WriteLine(arrayList);

            //Stack stack = new Stack();    //LİFO   Cipsi
            //stack.Push(4);
            //stack.Push("sdsfsfsf");
            //stack.Push(2.5);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();
            //// Console.WriteLine(stack[0]);*/  // It is wrong
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue();   //FİFO   Registration
            //queue.Enqueue(6);
            //queue.Enqueue("sdsfsfsf");
            //queue.Enqueue(4.7);
            //queue.Dequeue();   // del
            //foreach(var item in queue)
            //{
            //    Console.WriteLine(item);
            //}



            //SortedList sortedList = new SortedList();   //Sıralanmış şekilde çıxarır
            //sortedList.Add("Nicat", "0991111111");
            //sortedList.Add("Ferid", "0555555555");
            //sortedList.Add("Selim", "0502222222");
            //sortedList.Add("Subhan", "0554444444");
            //foreach(var item in sortedList.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable hashtable= new Hashtable();   //Lotoreya
            //hashtable.Add("nicat", "0991111111");
            //hashtable.Add("ferid", "0555555555");
            //hashtable.Add("selim", "0502222222");
            //hashtable.Add("subhan", "0554444444");
            //foreach(var item in hashtable.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //List<string> list = new List<string>();
            //list.Add("Nicat");
            //list.Add("Ferid");
            //list.Add("Selim");
            //list.Add("Subhan");
            //list.Clear();   // List del
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int>stack=new Stack<int>();
            //stack.Push(7);
            //stack.Push(10);
            //stack.Push(40);
            //stack.Clear();  // Stack del
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(7);
            //queue.Enqueue(10);
            //queue.Enqueue(40);
            //queue.Clear();  // queue del
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //SortedList<string, string> sortedList = new SortedList<string,string>(); //Sıralanmış şekilde çıxarır
            //sortedList.Add("Nicat", "0991111111");
            //sortedList.Add("Ferid", "0555555555");
            //sortedList.Add("Selim", "0502222222");
            //sortedList.Add("Subhan", "0554444444");
            //foreach (var item in sortedList)
            //{
            //    if (item.Key == "Selim")
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            Dictionary<int,string>dictionary=new Dictionary<int,string>();
            dictionary.Add(1,"Nicat");
            dictionary.Add(6,"Ferid");
            dictionary.Add(4,"Selim");
            dictionary.Add(2,"Subhan");
            dictionary.Remove(2);   // Qeyd olunanı silir
            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
