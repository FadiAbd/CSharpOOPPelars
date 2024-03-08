using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Wolfman : Wolf, IAnimal
    {
        public void Talk()
        {
            Console.WriteLine("Wolfman says: 'I am a creature of the night.'");
        }

    }
}
