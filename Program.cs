﻿using System;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a =random.Next(1,100);
            int guess = 0;
            string play = "Y";
            while (play == "Y") {
                Console.WriteLine("Guess Number");
                do {
                
                guess=Convert.ToInt32(Console.ReadLine());
                if (guess > a)
                    {
                        Console.WriteLine("doan so be hon");
                    }
                else if (guess < a)
                    {
                        Console.WriteLine("doan so lon hon");
                    }
            }
            while (a !=guess);
            Console.WriteLine($"doan dung r, so la {a} ban doan {guess}");
            Console.WriteLine("choi tiep khong Y/N");
                play = Console.ReadLine().ToUpper();
                if (play == "N") { Console.WriteLine("thank bro"); }
            }
        }
    }
}
 