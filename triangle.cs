using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class triangle : Shape
    {
        public double C {  get; set; }
        public override void getInfo()
        {
            Console.WriteLine($"This shape is {Name}, 3 param is {A} and {B} and {C}");
        }
        public override void getArea()
        {
            Console.WriteLine("{0} peri is: {1}", Name, (A * B) / 2);
            
         
        }
        public triangle(double a=0,double b = 0,double c = 0) { 
            Name = "Triangle";
            C = c;
            A=a; B=b;
        }
        public override void GetPeri() {
            Console.WriteLine("{0} perimeter is: {1}",Name,(A+B+C));
             }
        

        
    }
}
