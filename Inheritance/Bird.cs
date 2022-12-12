using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string Name  { get; set; }

        public int Inches  { get; set; }
        public string Color { get; set; }

        public bool HasLongLegs { get; set; }
        
        public  void Display()
    {
        Console.WriteLine($"The {Name} is {Inches} long and  is {Age} years old");
    }

    }

    
}
