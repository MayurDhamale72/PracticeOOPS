using PracticeOOPS;
using System;
using System.ComponentModel;

namespace ParcticeOPOS
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Encpsulation n = new Encpsulation();
            n.setName("Mayur");

            Console.WriteLine(n.getName());

            Dog d = new Dog();
            d.Eat();
            d.bark();

            Polymorphism p = new Polymorphism();
       
            
            Console.WriteLine(p.Add(2, 5));
            Console.WriteLine(p.Add(2, 5, 3));

            circle c = new circle();
            c.Draw();
            shape s = new shape();
            s.Draw();

            Employee vehicle = new Car();
            vehicle.start();

            BankAcc b = new BankAcc();
            b.Deposit(100);
            b.Withdraw(1000);
            Console.WriteLine(b.getBalance());

            Developer m = new Developer();
            m.Name = "Test User";
            m.Salary = 100;
            m.ProgrammingLanguage = "C#";

            m.DisplayDetails();


            int[] numbers = new int[5];
            numbers[0]= 1;
            numbers[1]= 2;
            numbers[2]= 3;
            numbers[3]= 4;
            numbers[4]= 5;
            //numbers[5]= 6;
            //numbers[6]= 7;

            string[] names = { "mayur", "om" };
            Console.WriteLine(names);
            
        }
    }
}
