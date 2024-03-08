using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Wolf : Animal, IAnimal
    {
        public bool IsWild { get; set; }

        public override void DoSound()
        {
            Console.WriteLine($"The Wolf says: Howl!");
        }

        public override string Stats()
        {
            return $"Name:{Name} Age:{Age} Weight:{Weight}";
        }
    }
}
