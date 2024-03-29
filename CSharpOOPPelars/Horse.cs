﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Horse : Animal, IAnimal
    {
        public int Height { get; set; }
        public override void DoSound()
        {
            Console.WriteLine($"The Horse says: Neigh!");
        }

        public override string Stats()
        {
            return $"Name:{Name} Age:{Age} Weight:{Weight}";
        }
    }
}
