using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            List<Student> studentList = new List<Student>();
            Student student = new Student("Metanet", "UUUU");
            Student student1 = new Student("Nicat", "TTTT");
            Student student2 = new Student("Subhan", "HHHH");
            studentList.Add(student);
            studentList.Add(student1);
            studentList.Add(student2);
            foreach(var item in studentList)
            {
                if (/*item.No == 2*/ item.No<=2)
                {
                    Console.WriteLine(item.No + " " + item.Name);
                }
                
            }
        }
    }
    public class Student
    {
        //public Student(string name)
        //{
        //    Name = name;
        //}
        public static int Nomre;
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            Nomre++;
            No = Nomre;
        }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public string Location { get; set; }

    }
}
