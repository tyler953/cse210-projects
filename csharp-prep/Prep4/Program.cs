using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int input;
        int total = 0;
        int max = 0;
        double average;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);
        
        foreach (int num in numbers)
        {
            total += num;
            if (num > max)
            {
                max = num;
            }
        }

        average = (double)total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}