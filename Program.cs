using PracticeOOPS;
using System;
using System.ComponentModel;
using System.Numerics;

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

            Fuctions f = new Fuctions();

            Console.WriteLine(f.Max(4, 7));

            Recursion r = new Recursion();
            r.PrintNum(5);

            Console.WriteLine(r.Factorial(5));
            Console.WriteLine(r.Add(5));
            r.PrintReverse(5);

            Console.WriteLine(r.Fibonacci(5));

            Sorting a = new Sorting();
            int[] arr = {7,8,9,10, 10, 0, 2, 1, 89};

            a.PrintArray(arr);
            //a.BubbuleSort(arr);
            a.SelectionSort(arr);
            a.PrintArray(arr);
        }
    }
}
