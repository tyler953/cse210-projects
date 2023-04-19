using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        Random randomGenerator = new Random();
        int correct = randomGenerator.Next(1, 101);
        do{
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > correct) {
                Console.WriteLine("Lower");
            } else if (guess < correct) {
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("Correct");
            }
        } while (correct != guess);
    }
}