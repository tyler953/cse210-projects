using System;

namespace Develop02
{
    public class Input
    {
        public int menu() 
        {
            Console.Write("Welcome to the Journal program!\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? "); 
            // string input = Console.ReadLine(); 
            int selectAction;
            if (!int.TryParse(Console.ReadLine(), out selectAction))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            return selectAction;
        }

        public string write()
        {
            Console.Write("->");
            string response = Console.ReadLine();
            return response;
        }

        public void load()
        {

        }

        public void save()
        {

        }
    }
}