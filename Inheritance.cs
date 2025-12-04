using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
   public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal can Eat");
        }
    }

    public class Dog : Animal 
    {
        public void bark()
        {
            Console.WriteLine("Dogs are bark");
        }
    }
}
