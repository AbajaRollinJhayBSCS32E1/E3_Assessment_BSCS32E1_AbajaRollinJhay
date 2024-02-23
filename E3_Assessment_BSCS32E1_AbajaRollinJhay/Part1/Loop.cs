using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Number\tSquare Root");
        Console.WriteLine("--------------------");

        // Iterate from 1 to 10
        for (int i = 1; i <= 10; i++)
        {
            double squareRoot = Math.Sqrt(i);
            Console.WriteLine($"{i}\t{squareRoot}");
        }
    }
}