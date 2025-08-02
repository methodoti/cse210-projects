// To exceed core requirements, the HideRandomWords method was enhanced.
// It first filters for only visible words, then randomly selects words to hide
// from that temporary list. This prevents the program from picking already-hidden
// words, making it more efficient and meeting the stretch goal.
using System;

class Program
{
    static void Main(string[] args)
    {
        int numbertoHide = 3;
        string menu = "";

        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        menu = Console.ReadLine();
        while ((!scripture.IsCompletelyHidden() && menu != "quit"))
        {
            scripture.HideRandomWords(numbertoHide);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            menu = Console.ReadLine();
        }
    }
}