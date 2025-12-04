using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOOPS
{
    internal class Encpsulation
    {
        private string name;

        public void setName(string n)
        {
            name = n;
        }

        public string getName()
        {
            return name; ;
        }
    }
}
