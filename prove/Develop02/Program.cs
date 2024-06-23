/* I added a validation to verify if the file exists before loading the journal and using a ~ as a delimiter reading or writing the file. Also, load the prompt list from a file named prompts.csv*/
using System;

class Program
{


    static void Main(string[] args)
    {

        Journal journal = new();
        Prompts prompts = new();
        List<Entry> entries = new();
        int option = 0;
        string fileName = "";

        do
        {
            Entry entry = new Entry();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following options:");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Exit");
            Console.WriteLine("What would you like to do? ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------");

            switch (option)
            {
                case 1:

                    DateTime date = DateTime.Now;
                    string prompt = prompts.RandomPrompt();
                    Console.WriteLine(prompt);
                    string content = Console.ReadLine();

                    entry._title = prompt;
                    entry._content = content;
                    entry._creationDate = date.ToShortDateString();
                    entries.Add(entry);

                    break;
                case 2:
                    entry.Display(entries);
                    break;
                case 3:
                    Console.WriteLine("File Name: ");
                    fileName = Console.ReadLine();
                    journal.Load(fileName, entries);
                    break;
                case 4:
                    Console.WriteLine("File Name: ");
                    fileName = Console.ReadLine();
                    journal.Save(fileName, entries);
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        } while (option != 5);

    }


}