using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
    internal class Polymorphism
    {
        public int Add(int a, int b)
        {
            return a+ b;
        }

        public int Add(int a, int b, int c) 
        {
            return a + b + c;
        }
    }

    public class shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("draw shape"); 
        }
    }

    public class circle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw circle");
        }
    }
}
