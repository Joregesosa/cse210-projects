using System;

class Program
{
    static void Main(string[] args)
    {
        Data data = new Data();
        Reference reference = new Reference(data.getBook(), data.getChapter(), data.getVerse(), data.getEndVerse());
        Scripture scripture = new Scripture(reference, data.getContent());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.getDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type quit to exit:");
            string input = Console.ReadLine();
            if (input == "quit" || scripture.isCompletelyHidden())
            {
                break;
            }

            scripture.hideRandomWord();

        }

    }
}