using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
    public abstract class Employees
    {
        public string Name;
        public double Salary;

        public abstract void DisplayDetails();
    }

    public class Developer : Employees
    {
        public string ProgrammingLanguage;

        public override void DisplayDetails()
        {
            Console.WriteLine(ProgrammingLanguage+ Name  + Salary);
        }
       
    }
}
