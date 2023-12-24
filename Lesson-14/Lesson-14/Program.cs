using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSquare calculateSquare = new CalculateSquare();
            calculateSquare.A = 4;
            calculateSquare.B = 7;
            calculateSquare.Calculate();
            Console.WriteLine(calculateSquare.Sahe);


            #region Email qoruma
            //Student student = new Student();
            //student.Email="nfdmrf@gmail.com";
            //Console.WriteLine(student.Email);
            #endregion
        }
    }
    class CalculateSquare
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Sahe
        {
            get { return _sahe; }
        }

        private int _sahe; // get; set;
        public void Calculate()
        {
            _sahe = A * B;
        }
    }

    #region Email qoruma
    ////Email qoruma
    //class Student
    //{
    //    private string _email;  //Field
    //    public string Email 
    //    {
    //        get { return _email; }
    //        set
    //        {
    //            try
    //            {
    //                MailAddress mailAddress = new MailAddress(value);
    //                _email = value;
    //            }
    //            catch
    //            {
    //                Console.WriteLine("Email formatı düzgün deyil");
    //            }
    //        }
    //    }
    //}
    #endregion
}
