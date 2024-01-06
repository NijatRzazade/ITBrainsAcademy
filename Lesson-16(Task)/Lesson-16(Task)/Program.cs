using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16_Task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            //while (true)
            //{
            //    Console.WriteLine("Select 1 to Add Student");
            //    Console.WriteLine("Select 2 to Exit");
            //    byte num = Convert.ToByte(Console.ReadLine());
            //    if (num == 1)
            //    {
            //        Console.WriteLine("Pleace Enter Your Name: ");
            //        string name = Console.ReadLine();
            //        Console.WriteLine("Enter Your Last Name: ");
            //        string surname = Console.ReadLine();
            //        Console.WriteLine("Please Enter Your Mourning: ");
            //        byte age=Convert.ToByte(Console.ReadLine());
            //        Student student = new Student(name, surname, age);
            //        Console.WriteLine(Student.counter + " " + student.Name + " " + student.Surname + " " + student.Age);
            //        Console.ReadLine();
            //    }
            //    else if (num == 2)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("There is No Such Option");
            //    }
            //}
            #endregion
            #region Task2
            Console.WriteLine("If you don't mind, choose a figure");
            string figure = Console.ReadLine();
            string a1 = "Rectangle";
            string a2 = "Triangle";
            string a3 = "Circle";
            string a4 = "Square";
            if (figure.ToLower() == a1.ToLower())
            {
                Console.WriteLine("1st please Enter the width");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("2st please Enter the lenght");
                int b = Convert.ToInt16(Console.ReadLine());
                Rectangle rectangle = new Rectangle(a, b);
                rectangle.CalculateArea();
                rectangle.CalculatePerimeter();
                Console.WriteLine("Area: " + rectangle.Area + "Perimeter: " + rectangle.Perimeter);
            }
            else if (figure.ToLower() == a2.ToLower())
            {
                Console.WriteLine("Please Enter First Party: ");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please Enter Second Party: ");
                int b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter seat if you don't mind: ");
                int c = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Pleace Enter pride: ");
                int d= Convert.ToInt16(Console.ReadLine());
                Triangle triangle = new Triangle(a,b,c,d);
                triangle.CalculateArea();
                triangle.CalculatePerimeter();
                Console.WriteLine("Area: " + triangle.Area + "Perimeter: " + triangle.Perimeter);
            }
            else if (figure.ToLower() == a3.ToLower())
            {
                Console.WriteLine("Please Enteer Radius: ");
                int a = Convert.ToInt16(Console.ReadLine());
                Circle circle = new Circle(a);
                circle.CalculateArea();
                circle.CalculatePerimeter();
                Console.WriteLine("Area: " + circle.Area + "Perimeter: " + circle.Perimeter);
            }

            else if(figure.ToLower() == a4.ToLower())
            {
                Console.WriteLine("1st please Enter the width");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("2st please Enter the lenght");
                int b = Convert.ToInt16(Console.ReadLine());
                Square square = new Square(a,b);
                square.CalculateArea();
                square.CalculatePerimeter();
                Console.WriteLine("Area: " + square.Area + "Perimeter: " + square.Perimeter);
            }
            #endregion
        }
    }
    // Task 1

    //public class Student
    //{
    //    public string Name { get;  }
    //    public string Surname { get; }
    //    public byte Age { get; }
    //    public int Counter { get; set; }

    //    public static int counter=1;
    //    public Student(string name,string surname,byte age)
    //    {
    //        Name = name;
    //        Surname = surname;
    //        Age = age;

    //        Counter++;
    //    }
    //}




    // Task 2

    interface IFigure
    {
        void CalculateArea();
        void CalculatePerimeter();
    }
    public class Parties
    {
        protected int Parties1 { get; set; }
        protected int Parties2 { get; set; }
        public Parties(int parties1, int parties2)
        {
            Parties1 = parties1;
            Parties2 = parties2;
        }
    }
    class Rectangle : Parties, IFigure
    {
        public Rectangle(int Prt1, int Prt2) : base(Prt1, Prt2) { }

        private int _Area;
        private int _Perimeter;
        public void CalculateArea()
        {
            _Area = Parties1 * Parties2;
        }
        public void CalculatePerimeter()
        {
            _Perimeter = 2 * (Parties1 * Parties2);
        }
        public int Area
        {
            get { return _Area; }
        }
        public int Perimeter
        {
            get { return _Perimeter; }
        }
    }
     class Circle
    {
        private double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        private double _Area;
        private double _Perimeter;
        double a = 3.14;
        public void CalculateArea()
        {
            _Area = a * (Radius * Radius);
        }
        public void CalculatePerimeter()
        {
            _Perimeter=a*(Radius * Radius);
        }
        public double Area
        {
            get { return _Area; }
        }
        public double Perimeter
        {
            get { return _Perimeter; }
        }
    }
    class Triangle : IFigure 
    {
        public Triangle(double sideA,double sideB, double sideC,double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;

        }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        private double _Area;
        private double _Perimeter;
        public void CalculateArea()
        {
            _Area = (SideA + SideB + SideC + SideD) / 2;
        }
        public void CalculatePerimeter()
        {
            _Perimeter= SideA + SideB + SideC + SideD;
        }
        public double Area
        {
            get { return _Area; }
        }
        public double Perimeter
        {
            get { return _Perimeter; }
        }
    }
    class Square : IFigure
    {
        public double SideA;
        public double SideB;
        public Square(double side1,double side2)
        {
            SideA = side1;
            SideB = side2;

        }
        private double _Area;
        private double _Perimeter;
        public void CalculateArea()
        {
            _Area = SideA * SideB;
        }
        public void CalculatePerimeter()
        {
            _Perimeter = 4 * SideA;
        }
        public double Area
        {
            get { return _Area; }
        }
        public double Perimeter
        {
            get { return _Perimeter; }
        }
    }
}
