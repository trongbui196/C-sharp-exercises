﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        public Circle(double a) { A = a; Name = "Cirlce"; }
        public override void getInfo()
        {
            Console.WriteLine($"This shape is {Name}, 1 param is {A} a");
        }
        public override void getArea()
        {
            Console.WriteLine("{0} peri is: {1}", Name, Math.Pow(A, 2) * Math.PI);

        }

        public override void GetPeri()
        {
            Console.WriteLine("{0} peri is: {1}", Name, A * Math.PI * 2);

        }
    }
}
