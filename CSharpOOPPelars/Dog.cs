﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPPelars
{
    internal class Dog : Animal,IAnimal
    {
        public bool IsTrained { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Bark!");
        }
    }
}