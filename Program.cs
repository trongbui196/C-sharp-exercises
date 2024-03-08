using System;
using System.Collections.Generic;
using System.Text;
//public class CountCharactersInString
//{
//    static public void ParseText(string data)
//    { int count2 = 0;
//        char[] intt= new char[data.Length];
//        StringBuilder sb = new StringBuilder();
//        if (data.Length == 0)
//        {
//            Console.WriteLine("empty");
//        }
//        else
//        {
//            for (int i = 0; i < data.Length; i++)
//            {
//                if (!intt.Contains(data[i]))
//                {
//                    intt[count2] = data[i];
//                    count2++;
//                    int count = 1;
//                    for (int j = i + 1; j < data.Length; j++)
//                    {

//                        if (data[i] == data[j])
//                        {
//                            count++;
//                        }
//                    }
//                    sb.Append($"{data[i]} {count},");
//                }
//            }
//            sb.Replace("  ", "space ");
//        }
//        //Input your solution here
//        Console.WriteLine(sb);
//    }

//    static public void Main()
//    {

//        string input1 = "abccca388**";
//        string input2 = "aaaaaaccccc";
//        string input3 = "";
//        string input4 = "abc";
//        string input5 = "   ";
//        string input6 = "a c d e^^^^";
//        string input7 = "Hello Everyone";


//        ParseText(input1);
//        ParseText(input2);
//        ParseText(input3);
//        ParseText(input4);
//        ParseText(input5);
//        ParseText(input6);
//        ParseText(input7);

//    }
//}
using System;
using System.Collections.Generic;
using System.Text;
class Program
{
    static string CalculateGrade(double input)
    {
        if (input >= 90)
            return "A";
        else if (input >= 80 && input < 90)
            return "B";
        else if (input >= 70 && input < 80)
            return "C";
        else if (input >= 60 && input < 70)
            return "D";
        else
            return "F";
    }

    static bool IsValidInput(double input)
    {
        if (input < 0 || input > 100)
            return false;
        else
            return true;
    }

    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        StringBuilder sb2 = new StringBuilder();
        int invalid = 0;
        var cases = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cases; i++)
        {
            var input = double.Parse(Console.ReadLine());

            if (IsValidInput(input))
            {
                var grade = CalculateGrade(input);
                Console.WriteLine($"Case {i}: {grade}");
                sb.Append(grade);
            }
            else
            {
                Console.WriteLine($"Case {i}: Invalid input");
                invalid++;
            }

            // TODO: Count the Grade and Invalid cases
        }
        int a = sb.Length-sb.Replace("A", "").Length;
        int b = sb.Length - sb.Replace("B", "").Length;
        int c = sb.Length - sb.Replace("C", "").Length;
        int d = sb.Length - sb.Replace("D", "").Length;
        int f = sb.Length - sb.Replace("F", "").Length;
        if (a > 0)
        { sb2.Append($"A-{a} "); }
        if (b > 0)
        { sb2.Append($"B-{b} "); }
        if (c > 0)
        { sb2.Append($"C-{c}"); }
        if (d > 0)
        { sb2.Append($"D-{d} "); }
        if (f > 0)
        { sb2.Append($"F-{f} "); }
        Console.WriteLine("Summary {0} Invalid-{1}", sb2, invalid);
    }
}