using System.Text;


namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {   string again = "Y";
            
            do { 
            Console.WriteLine("Choose your shape: ");
            Console.WriteLine("1.Rectangle");
            Console.WriteLine("2.Triangle");
            Console.WriteLine("3.Cirlce");
            int shape =Convert.ToInt32(Console.ReadLine());
            switch (shape)
            {       default: Console.WriteLine("Choose between 1-3");break;
                    case 1:
                        Console.WriteLine("-----------");
                        Console.WriteLine("You choose Rectangle");
                        Console.WriteLine("Input Length: ");
                        int l=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input Width:");
                        int w = Convert.ToInt32(Console.ReadLine());
                        Shape rect= new Shape("Rectangle",l,w);
                        rect.getInfo(); 
                        rect.GetPeri();
                        rect.getArea();
                        Console.WriteLine("Reset? Y/N");
                        again = Console.ReadLine().ToUpper();
                        break;
                    case 2:
                        Console.WriteLine("-----------");
                        Console.WriteLine("You choose Triangle");
                        Console.WriteLine("Input Side 1: ");
                        int side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input Side 2: ");
                        int side2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Input Side 3: ");
                        int side3 = Convert.ToInt32(Console.ReadLine());
                        Shape tria = new triangle(side1, side2,side3);
                        tria.getInfo();
                        tria.GetPeri();
                        tria.getArea();
                        Console.WriteLine("Reset? Y/N");
                        again = Console.ReadLine().ToUpper();
                        break;
                    case 3:
                        Console.WriteLine("-----------");
                        Console.WriteLine("You choose Circle");
                        Console.WriteLine("Input Raidus: ");
                        int rad = Convert.ToInt32(Console.ReadLine());
                        Shape cir = new Circle(rad);
                        cir.getInfo();
                        cir.GetPeri();
                        cir.getArea();
                        Console.WriteLine("Reset? Y/N");
                        again = Console.ReadLine().ToUpper();
                        break;
                }
            } while (again == "Y");
        }
    }
}
 