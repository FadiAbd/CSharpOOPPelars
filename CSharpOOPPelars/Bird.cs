using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Bird : Animal, IAnimal
    {
        public double WingSpan { get; set; }

        public override void DoSound()
        {
            Console.WriteLine($"The Bird says: Tweet!");
        }

        public override string Stats()
        {
            return $"Name:{Name} Age:{Age} Weight:{Weight}";
        }
    }
}
