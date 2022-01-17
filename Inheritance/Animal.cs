using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal:Interface1
    {

        public int numberofLegs;
        public string Name;
        public string Type;

        public Animal(int leg, string name, string type)
        {
            numberofLegs = numberofLegs;
            Name = name;
            Type = type;
        }


        public void movement()
        {

        }

        public void printinfo()
        {

        }

        public string PrintAnimal(string type)
        {
            return type;
        }
    }
}
