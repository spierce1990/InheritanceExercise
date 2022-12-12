using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsGreen { get; set; }

        public string MainFood { get; set; }

        public bool Swim  { get; set; }

        public bool Climb { get; set; }
    }
}
