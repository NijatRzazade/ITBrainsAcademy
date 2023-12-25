using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12__Task_
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Please select the new product:");
                Console.WriteLine("If the product is food, 1 Press it:");
                Console.WriteLine("If Drink Is Responsible 2 Squeeze It Out:");
                byte nom = Convert.ToByte(Console.ReadLine());


                if (nom == 2)
                {
                    Console.WriteLine("Enter the product name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Set a Product Price:");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the Product Weight:");
                    double volume = Convert.ToDouble(Console.ReadLine());

                    Beverage beverage = new Beverage(name, price, volume);
                    beverage.DisplayDetails();
                }
                else if (nom == 1)
                {
                    Console.WriteLine("Enter the product name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Set a Product Price");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Set an Expiration Time:(Day Moon Year)");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Is the product suitable for vegetarians?:");
                    string YesNo = Console.ReadLine();
                    bool vegterian = false;
                    if (YesNo == "Yes")
                    {
                        vegterian = true;
                    }
                    else if (YesNo == "No")
                    {
                        vegterian = false;
                    }



                    Food food = new Food(name, price, date, vegterian);
                    food.DisplayDetails();

                }
                else
                {
                    Console.WriteLine("Please select again if you don't mind");
                }
                Console.ReadLine();
            }

    }
        public abstract class Product
        {
            public static int No;
            public int id { get; set; }
            public string name { get; set; }
            public double price { get; set; }

            public Product(string Name, double Price)
            {
                name = Name;
                price = Price;
                No++;
                id = No;
            }
            public virtual void DisplayDetails()
            {
                Console.WriteLine("No: " + id + " Name: " + name + " Value: " + price);
            }
        }
        public class Beverage : Product
        {
            public double volume { get; set; }
            public Beverage(string nm, double pr, double Volume) : base(nm, pr)
            {
                volume = Volume;
            }
            public override void DisplayDetails()
            {
                Console.WriteLine("No: " + id + " Name: " + name + " Value: " + price + " Volume: " + volume);
            }
        }
        public class Food : Product
        {
            public DateTime ExpirationDate { get; set; }
            public bool IsVegetarian { get; set; }
            public Food(string nmn, double prr, DateTime expirationdate, bool isVegetarian) : base(nmn, prr)
            {
                ExpirationDate = expirationdate;
                IsVegetarian = isVegetarian;

            }

            public override void DisplayDetails()
            {
                Console.WriteLine("Id: " + id +"\r\n" + " Name: " + name + "\r\n"  +" Price: " + price +"\r\n" +" ISVegetarian: " + IsVegetarian +"\r\n" +" Son Istifade: " + ExpirationDate);
            }


        }
}

