using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>arrayList=new List<int> {1,2,3,4,5,6,7,8,9,10 };
            // İlk beş elementin yerini deyiş
            int temp;
            for(int i = 0; i < 5; i++)
            {
                temp = arrayList[i];
                arrayList[i] = arrayList[i + 5];
                arrayList[i + 5] = temp;
            }
            //Neticeni ekrana çap et
            foreach( int item in arrayList)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
