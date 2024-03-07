using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Worm : Animal, IAnimal
    {
        public bool IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Hisss!");
        }
    }
}
