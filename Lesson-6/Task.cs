using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentslist = new ArrayList();

            while (true)
            {

                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Display Students");
                Console.WriteLine("5. Search by Student name and show all of data of this student");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                byte says = Convert.ToByte(Console.ReadLine());

                if (says == 6)
                {
                    break;
                }
                switch (says)
                {
                    case 1:


                        Console.WriteLine("Enter the student's name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the student's last name:");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter the student's Age:");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Enter the student's score:");
                        byte resualt = Convert.ToByte(Console.ReadLine());
                        dynamic students = new { namest = name, surnamest = surname, agest = age, resualtst = resualt };

                        studentslist.Add(students);
                        foreach (dynamic item in studentslist)
                        {
                            Console.WriteLine("Name: " + item.namest + " Surname: " + item.surnamest + " Age: " + item.agest + " Resualt:" + item.resualtst);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of the student you want to edit:");
                        string name3 = Console.ReadLine();
                        for (dynamic i = 0; i < studentslist.Count; i++)
                        {
                            if (studentslist[i].namest == name3)
                            {
                                studentslist.RemoveAt(i);

                                Console.WriteLine("Edit Student's Name:");
                                string name4 = Console.ReadLine();
                                Console.WriteLine("Edit Student's Last Name:");
                                string surname1 = Console.ReadLine();
                                Console.WriteLine("Edit Student's Age:");
                                byte age1 = Convert.ToByte(Console.ReadLine());
                                Console.WriteLine("Edit Student Result:");
                                byte result1 = Convert.ToByte(Console.ReadLine());

                                dynamic says2 = new { namest = name4, surnamest = surname1, agest = age1, resultst = result1 };

                                studentslist.Add(says2);


                            }
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the student you want to remove:");
                        string delete = Console.ReadLine();
                        for (dynamic i = 0; i < studentslist.Count; i++)
                        {
                            if (studentslist[i].namest == delete)
                            {
                                studentslist.RemoveAt(i);
                            }
                        }

                        break;
                    case 4:
                        foreach (dynamic item in studentslist)
                        {
                            Console.WriteLine("Name: " + item.namest + " Surname: " + item.surnamest + " Age: " + item.agest + " Resualt:" + item.resualtst);
                        }
                        break;
                    case 5:
                        if (studentslist.Count > 0)
                        {
                            Console.WriteLine("Enter the student's name:");
                            string name2 = Console.ReadLine();
                            foreach (dynamic item in studentslist)
                            {
                                if (item.namest == name2)
                                {
                                    Console.WriteLine("Name: " + item.namest + " Surname: " + item.surnamest + " Age: " + item.agest + " Resualt:" + item.resualtst);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no students listed!!!");
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

