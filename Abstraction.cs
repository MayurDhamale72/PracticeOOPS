using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
 
    public abstract class Employee
    {
        public abstract void start();
    }

    public class Car : Employee
    {
        public override void start()
        {
            Console.WriteLine("abtarct");
        }
    }
}
