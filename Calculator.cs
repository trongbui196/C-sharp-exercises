using System;
namespace ConsoleApp1
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            string again = "Y";
            string ope = "";
            while (again == "Y")
            {
                Console.WriteLine("Welcome to calculator ");
                Console.WriteLine("-------");
                Console.WriteLine("First number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------");
                Console.WriteLine("Choose Operator");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("x");
                Console.WriteLine("/");
                Console.Write("Your choice: ");
                ope = Console.ReadLine();

                switch (ope)
                {
                    case "+":
                        Console.WriteLine("-------");
                        Console.Write($"{a} {ope} {b} is: ");
                        Console.WriteLine(doSumm(a, b));
                        break;
                    case "-":
                        Console.WriteLine("-------");
                        Console.Write($"{a} {ope} {b} is: ");
                        Console.WriteLine(doMinus(a, b));
                        break;
                    case "x":
                        Console.WriteLine("-------");
                        Console.Write($"{a} {ope} {b} is: ");
                        Console.WriteLine(doMultiply(a, b));
                        break;
                    case "/":
                        Console.WriteLine("-------");
                        Console.Write($"{a} {ope} {b} is: ");
                        Console.WriteLine(doDivide(a, b));
                        break;
                    default:
                        Console.WriteLine("incorrect operation");
                        break;

                }
                Console.WriteLine("Reset? Y/N");
                again = Console.ReadLine().ToUpper();
                if (again == "N") { Console.WriteLine("Thank you! Bye bye"); }
            }
        }

        public static int doSumm(int a, int b)
        {
            return a + b;
        }
        static int doMinus(int a, int b)
        {
            return a - b;
        }
        static int doMultiply(int a, int b)
        {
            return a * b;
        }
        static int doDivide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("can't divide to 0");
                Console.WriteLine("try another number");
                return b;
            }
            else
                return a / b;

        }
    }
}

