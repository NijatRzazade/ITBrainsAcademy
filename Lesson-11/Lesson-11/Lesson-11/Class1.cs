using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class Student
    {
        public static int Nomre;
        public static List<Student> StudentList=new List<Student>();
        public Student(string name, string surname)
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

        //public static void Test()
        //{
        //    Console.WriteLine($"{Nomre} telebe var");
        //}
        //public void Fullname()
        //{
        //    Console.WriteLine(Name + " " + Surname);
        //}

        public static void AddStudent(Student student)
        {
            StudentList.Add(student);
        }
        public static void RemoveStudent(int Id)
        {
            foreach(var item in StudentList)
            {
                if (item.No == Id)
                {
                    StudentList.Remove(item);
                }
            }
        }
        public void GetFullName()
        {
            Console.WriteLine(No+" . "+Name + " " + Surname);
        }
    }
}
