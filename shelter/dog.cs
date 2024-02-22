﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class dog : animal
    {
        public string Sound2 { get; set; } = "meowwwww";
        public dog(string name, string sound, string sound2) : base(name, sound)
        {

            Sound2 = sound2;
        }
        public override void speak()
        {
            Console.WriteLine($"{Name} is bilingual so it can say both {Sound} and {Sound2}");
        }
    }
}