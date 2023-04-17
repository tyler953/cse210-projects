using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you recieve for the class? ");
        string percentage = Console.ReadLine();
        int num = int.Parse(percentage);
        
        char letter;
        if (num >= 90)
        {
            letter = 'A';
        }
        else if (num >= 80)
        {
            letter = 'B';
        } else if (num >= 70)
        {
            letter = 'C';
        } else if (num >= 60)
        {
            letter = 'D';
        } else
        {
            letter = 'F';
        }

        Console.WriteLine($"You recieved a {letter} as your final grade.");
        if (num >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        } else
        {
            Console.WriteLine("You didn't quite pass the class. Better luck next time.");
        }
    }
}