using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region class
            //var Student1 = new { Name = "Nicat", Surname = "Rzazade", age = 20 };
            //var Student2 = new { Name = "Ferid", Surname = "Sultanov", age = 19 };
            //var Student3 = new { Name = "Subhan", Surname = "FFF", age = 24 };

            //List < object > list= new List<object>();
            //list.Add(Student1);
            //list.Add(Student2);
            //list.Add(Student3);

            //foreach(dynamic item in list)
            //{
            //    byte x = item.age;
            //    Console.WriteLine(item.age);
            //}

            //int a = 5;
            //Student student = new Student { Name = "Selim", Surname = "TTT", Age = 20 };
            //student.Surname = "HHH";
            ////Console.WriteLine(student.Name + " " + student.Surname);

            //Student student1 = new Student("Nicat","Rzazade");

            //Console.WriteLine(student1.Name+" "+student1.Surname);
            //student1.Name = "Nicat";
            //student1.Surname = "KKK";
            //student1.Age = 20;

            //List<Student> students = new List<Student>();
            //students.Add(student);
            //students.Add(student1);

            //foreach(var item in students)
            //{
            //    Console.WriteLine(item.Name+ " "+ item.Surname);
            //}

            //Student stName = new Student("Nihat");

            //list<student> studentlist = new list<student>();
            //Student student = new Student("Metanet", "UUUU");
            //Student student1 = new Student("Nicat", "TTTT");
            //Student student2 = new Student("Subhan", "HHHH");
            //studentList.Add(student);
            //studentList.Add(student1);
            //studentList.Add(student2);
            //foreach (var item in studentList)
            //{
            //    if (/*item.No == 2*/ item.No <= 2)
            //    {
            //        Console.WriteLine(item.No + " " + item.Name);
            //    }

            //}
            #endregion

            //Student st = new Student("Eli", "Elili");
            //st.Fullname();
            //Student student1 = new Student("Nicat", "TTTT");
            //Student.Test();

            //Test.CheckEven(5);

            //List<Student> StudentList = new List<Student>();

            //Console.Write("Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Surname: ");
            //string surname = Console.ReadLine();

            //Student student = new Student(name, surname);


            //Student student = new Student("Nicat","Rzazade");


            //StudentList.Add(student);
            //Student.StudentList.Add(student);

            Console.WriteLine("1-Yeni telebe yarat \r\n2-Yeni qrup yarat");
            string option=Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Surname: ");
                    string surname = Console.ReadLine();
                    Student student = new Student(name,surname);

                    Student.AddStudent(student);
                    student.GetFullName();
                    break;
                    case "2":
                    Console.Write("Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Student.RemoveStudent(id);
                    break;
                default:
                    break;
            }
        }
    }
    public static class Test
    {
        public static void CheckEven(int data)
        {
            if (data % 2 == 0)
            {
                Console.WriteLine("Bu cüt ededdir");
            }
            else
            {
                Console.WriteLine("Bu tek ededdir");
            }
        }
    }
}

