using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shape

    {   public string Name { get; set; }
        public double A {  get; set; }
        public double B { get; set; }
        public Shape(string name = "Rectangle", double a = 0,double b=0) {
            this.A = a; 
            this.B = b;
            this.Name = name;
        }

        

        public virtual void getInfo()
        {
            Console.WriteLine($"This shape is {Name}, 2 param is {A} and {B}");
        }

        public virtual void GetPeri()
        {
            Console.WriteLine("{0} peri is: {1}",Name, 2 * (A + B));
        }
         public virtual void getArea()
        {
            Console.WriteLine("{0} area is: {1}",Name, A * B);
            
        }

    }
}
