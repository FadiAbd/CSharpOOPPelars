using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Hedgehog : Animal, IAnimal
    {
        public int NrOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine($"The Hedgehog says: Prsss!");
        }

        public override string Stats()
        {
            return $"Name:{Name} Age:{Age} Weight:{Weight}";
        }
    }
}
