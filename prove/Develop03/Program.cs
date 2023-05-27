using System;

namespace Develop03
{
    public class Program
    {
        static void Main()
        {
            bool quit = false;
            Scripture scripture = new Scripture();
            Reference reference = new Reference();
            Word words = new Word();

            scripture.ChooseNewScripture();
            reference.StoreReference(scripture.GetScripture());
            words.StoreHiddenScripture(scripture.GetScripture());

            Console.WriteLine($"{scripture.GetScripture()}\n");

            do
            {
                Console.WriteLine("Press enter to continue, type 'quit' to finish, or type 'show' to show the scripture:");
                string input = Console.ReadLine();

                if (input == "")
                {
                    Console.Clear();
                    words.HideWords();
                    Console.WriteLine($"{reference.GetReference()}");
                    Console.WriteLine($"{words.GetHiddenScripture()}\n");
                } else if (input == "quit")
                {
                    Console.Clear();
                    quit = true;
                } else if (input == "show")
                {
                    Console.WriteLine($"\n{scripture.GetScripture()}\n");
                } else
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (!quit);
        }
    }
}