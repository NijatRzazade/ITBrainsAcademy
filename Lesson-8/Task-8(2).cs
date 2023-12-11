using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string tipli Queue list yaratmaq
            Queue<string> queueList = new Queue<string>();

            byte a = 10;
            while (true)
            {
                Console.WriteLine("Do you want to write a message?");
                string yesno=Console.ReadLine();
                if (yesno == "Yes")
                {
                    Console.WriteLine("Write the word");
                    string Sentence= Console.ReadLine();
                    queueList.Enqueue(Sentence);
                    if (queueList.Count > 10)
                    {
                        queueList.Dequeue();
                        queueList.Enqueue(Sentence);
                    }
                }
                else if (yesno == "No")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("There is no name for such a country");
                }
            }
        }
    }
}
