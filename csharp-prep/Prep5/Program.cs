using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(name, square);
    }
}