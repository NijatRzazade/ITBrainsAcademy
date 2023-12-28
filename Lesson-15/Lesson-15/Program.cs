using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuniorDeveloper juniorDeveloper = new JuniorDeveloper("Nicat","Rzazade","C#");
            juniorDeveloper.Age = 20;
            juniorDeveloper.Read("Employee", "Nicat");
        }
    }
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set;}
        public Employee(string nm,string srnm)
        {
            Name = nm;
            Surname = srnm;
        }

    }
    interface ICreateDeleteUpdate
    {
        void Add(string table, object obj);
        void Delete(string table, object obj);
        void Update(string table, object obj);
    }
    interface ISelect
    {
        void Read(string table, object obj);
    }
    class JuniorDeveloper : Employee,ISelect
    {
        public string ProgramingLang { get; set; }
        public JuniorDeveloper(string nm, string srnm,string Lang) : base(nm, srnm)
        {
            ProgramingLang = Lang;
        }

        public void Read(string table, object obj)
        {
            throw new NotImplementedException();
        }
    }
    class Middle : ICreateDeleteUpdate
    {
        public void Add(string table, object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string table, object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(string table, object obj)
        {
            throw new NotImplementedException();
        }
    }

    class SeniorDeveloper : Employee,ISelect,ICreateDeleteUpdate
    {
        public string ProgramingLang { get; set; }
        public SeniorDeveloper(string nm, string srnm, string Lang) : base(nm, srnm)
        {
            ProgramingLang = Lang;
        }

        public void Read(string table, object obj)
        {
            throw new NotImplementedException();
        }

        public void Add(string table, object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string table, object obj)
        {
            throw new NotImplementedException();
        }

        public void Update(string table, object obj)
        {
            throw new NotImplementedException();
        }
    }
}
