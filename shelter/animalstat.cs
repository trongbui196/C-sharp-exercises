﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class animalstat
    {
        public double Weight { get; set; } = 0;
        public double Age { get; set; } = 0;
        public double Height { get; set; } = 0;
        public int ID { get; set; } = 0;
        public string Ownername { get; set; } = "Trong";
        public bool isHealthy
        {
            get
            {
                if (Age < 5 && Weight >= 50) { return false; }
                else return true;
            }
            set
            {

            }
        }

    }
}