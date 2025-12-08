using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
    public class Recursion
    {
        public void PrintNum(int num)
        {
            if (num == 0)
                return;

            PrintNum(num - 1);

            Console.WriteLine(num + " ");
        }

        public int Factorial(int n)
        {
            if (n == 1)
                return 1;

            return n * Factorial(n - 1);

        }

        public int Add(int a)
        {
            if (a == 1)
                return 1;

            return a + Add(a - 1);
        }

        public void PrintReverse(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            PrintReverse(n - 1);
           
        }

        public int Fibonacci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
