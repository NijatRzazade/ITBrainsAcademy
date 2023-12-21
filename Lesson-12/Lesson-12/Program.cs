using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Minaya","TTTT", "Programming");
            teacher.Position = "Senior";
            teacher.Salary = 800.30;
            teacher.BonusSalary();
            //Console.WriteLine(teacher.Name);
            //Console.WriteLine(teacher.ID);
            Console.WriteLine(teacher.ID+ " "+ teacher.Bonus + " " + teacher.Name + " " + teacher.Salary);
            //teacher.GetFullname();
            

            Teacher teacher2 = new Teacher("Nicat", "XXXXX", "Programming");
            teacher2.Position = "Middle";
            teacher2.Salary = 560.45;
            teacher2.BonusSalary();
            //Console.WriteLine(teacher.Name);
            //Console.WriteLine(teacher2.ID);
            Console.WriteLine(teacher2.ID + " " + teacher2.Bonus + " " + teacher2.Name + " " + teacher2.Salary);
            //teacher2.GetFullname();


            Texnik texnik = new Texnik("Eli","Elili");
            texnik.Forma = false;
            texnik.Salary = 320.60;
            texnik.Position = "Helpdesk";
            texnik.BonusSalary();
            //Console.WriteLine(texnik.Name);
            //Console.WriteLine(texnik.ID);
            Console.WriteLine(texnik.ID + " " + texnik.Bonus + " " + texnik.Name + " " + texnik.Salary);
            //texnik.GetFullname();


            Console.WriteLine(Employee.No + " Umumi işçilerin sayi");
            
        }
    }
    public abstract class Employee   //Base Class
    {
        public static int No;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public int ID { get; set; }
        public Employee(string nm,string srnm)
        {
            Name = nm;
            Surname = srnm;
            No++;
            ID = No;
        }
        public virtual void GetFullname()
        {
            Console.WriteLine(Name + " " + Surname);
        }
        //public virtual void BonusSalary()
        //{
        //    Bonus = Salary * 0.3;
        //}
        public abstract void BonusSalary();
    }
    public class Teacher:Employee  // Derived Class
    {
        public string Subjekt { get; set; }
        public Teacher(string namee,string surnamee,string subjekt) : base(namee, surnamee)
        {
            Subjekt = subjekt;
        }
        public override void BonusSalary()
        {
            Bonus = Salary * 0.6;
        }
    }
    public class Texnik:Employee
    {
        public Texnik(string ad,string soyad):base(ad, soyad) { }
        public bool Forma { get; set; }
        public override void BonusSalary()
        {
            Bonus = Salary * 0.3;
        }
    }
}
