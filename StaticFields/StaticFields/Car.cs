using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFields
{
    internal class Car
    {

        internal string test = "Testing internal property!";

        public static string name;
        public double price;

        public int horsepower = 600;

        public int GetHorsepower()
        {
            return this.horsepower;
        }

        internal string testMethod()
        {
            return this.test;
        }

    }
}
