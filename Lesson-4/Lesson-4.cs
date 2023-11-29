using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentArr = { "Nicat", "Ferid" };

            string name = "Nicat";
            byte age = 19;

            var nicatData = new { name = "Nicat", age = 19, surname = "Heyderzade" };
            var metanetData = new { name = "Metanet", age = 20, surname = "Adigozelova" };
            Console.WriteLine(nicatData.name);
            Console.WriteLine(nicatData.age);
            Console.WriteLine(nicatData.surname);

            dynamic[] studentData = { nicatData, metanetData };
            Console.WriteLine(studentData[0].name);
            foreach (var item in studentData)
            {
                Console.WriteLine(item.surname);
            }



            ///////////////////////////////////////////////


            dynamic[] studentList = new dynamic[0];
            int count = 0;
            while (true)
            {

                Console.WriteLine("1. Student add");
                Console.WriteLine("2. Student list");
                Console.WriteLine("3. Program close");
                Console.WriteLine("4. Search by student name ");

                int chose = Convert.ToInt32(Console.ReadLine());

                if (chose == 3)
                {
                    break;
                }

                switch (chose)
                {
                    case 1:
                        Console.WriteLine("Telebenin adini daxil et");
                        string nameSt = Console.ReadLine(); ;
                        Console.WriteLine("Telebenin soyadini daxil et");
                        string surnameSt = Console.ReadLine(); ;
                        Console.WriteLine("Telebenin yasini daxil et");
                        byte ageSt = Convert.ToByte(Console.ReadLine());

                        var telebe = new { name = nameSt, age = ageSt, surname = surnameSt };
                        count++;
                        Array.Resize(ref studentList, count);

                        studentList[count - 1] = telebe;

                        Console.WriteLine("Telebe daxil edildi " + studentList[count - 1].name + " " + studentList[count - 1].surname + " " + studentList[count - 1].age);
                        break;
                    case 2:

                        foreach (var item in studentList)
                        {
                            Console.WriteLine(item.name + " " + item.surname);
                        }
                        break;
                    case 4:
                        if (studentList.Length > 0)
                        {
                            Console.WriteLine("Axtardiginiz telebenin adini daxil edin");
                            string searchSt = Console.ReadLine();
                            foreach (var item in studentList)
                            {
                                if (item.name == searchSt)
                                {
                                    Console.WriteLine(item.name + " " + item.surname + " " + item.age);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Siyahida telebe yoxdur");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}