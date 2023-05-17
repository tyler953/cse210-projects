using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Input newInput = new Input();
            List<List<Entry>> entriesList = new List<List<Entry>>();
            bool quit = false;
            Journal newJournal = new Journal();

            do
            {
                int selected = newInput.menu();
                Prompts prompts = new Prompts();
                if (selected == 1)
                {
                    Entry newEntry = new Entry();
                    string prompt = prompts.getRandomPrompt();
                    Console.WriteLine(prompt);
                    newEntry.StorePrompt(prompt);
                    string response = newInput.write();
                    newEntry.StoreResponse(response);
                    string date = DateTime.Now.ToString("dd/MM/yyyy");
                    newEntry.StoreDate(date);
                    newJournal.StoreEntry(newEntry);

                } else if (selected == 2)
                {
                    
                    List<Entry> entries = newJournal.GetEntries();
                    Console.WriteLine();
                    foreach (Entry entry in entries)
                    {
                        string message = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                        Console.WriteLine(message);
                    }

                } else if (selected == 3)
                {
                    Console.WriteLine("What file would you like to load from?");
                    Console.Write("-> ");
                    string fileName = Console.ReadLine();
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;
                        Entry entry = null;

                        while((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith(DateTime.Now.ToString("dd/MM/yyyy")))
                            {
                                entry = new Entry();
                                entry.StoreDate(line);
                                entry.StorePrompt(sr.ReadLine());
                                entry.StoreResponse(sr.ReadLine());
                                newJournal.StoreEntry(entry);
                            }
                        }
                    }




                } else if (selected == 4)
                {
                    Console.WriteLine("What file would you like to save to?");
                    Console.Write("-> ");
                    string fileName = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        List<Entry> entries = newJournal.GetEntries();
                        foreach (Entry entry in entries)
                        {
                            string message = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}";
                            writer.WriteLine(message);
                        }
                    }


                } else if (selected == 5)
                {
                    quit = true;

                } else 
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (quit == false);
            


            // Entry myEntry = new Entry();
            // myEntry.StorePrompt("What is your name?");
            // myEntry.StoreResponse("Tyler Wright");
            // myEntry.StoreDate("8 May 2023");

            // Entry yourEntry = new Entry();
            // yourEntry.StorePrompt("What is your favorite food?");
            // yourEntry.StoreResponse("Bulgogi");
            // yourEntry.StoreDate("8 May 2023");
            

            // Journal journal = new Journal();
            // journal.StoreEntry(myEntry);
            // journal.StoreEntry(yourEntry);

            // List<Entry> entries = journal.GetEntries();
            // foreach (Entry entry in entries)
            // {
            //     string message = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
            //     Console.WriteLine(message);
            // }
        }
    }
}