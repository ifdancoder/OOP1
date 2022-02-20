using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("ax: ");
        double ax = double.Parse(Console.ReadLine());
        Console.Write("by: ");
        double by = double.Parse(Console.ReadLine());
        Console.WriteLine("Your answer is: " + (ax * a + b == by ? "YES" : "NO"));
    }
}