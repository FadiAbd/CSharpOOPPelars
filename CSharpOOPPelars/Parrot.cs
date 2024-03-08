using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Parrot : Animal, IPerson
    {
        public void Talk()
        {
           
        }
        public override string Stats()
        {
            return $"Name:{Name} Age:{Age} Weight:{Weight}";
        }

        public override void DoSound()
        {
            Console.WriteLine($"The Parrot says: Hello!");
        }
    }
}
