// Exceeds Core Requirements
// To exceed the core requirements, the program has been enhanced to save and load
// the journal to and from a CSV (Comma Separated Values) file.
// This implementation correctly handles potential commas within user entry text
// by enclosing all fields in double quotes. It also writes a header row to the
// CSV file, making it easily compatible and readable in spreadsheet applications
// like Microsoft Excel.

using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator thePrompt = new PromptGenerator();
        Journal theJournal = new Journal();

        string menuChoice;
        string myPromptText;
        string myEntryText;
        string myFileName;

        Console.WriteLine("------------------------------------");
        Console.WriteLine(" WELL COME TO YOUR PERSONAL JOURNAL");
        Console.WriteLine("------------------------------------");

        do
        {
            DateTime theCurrentTime = DateTime.Now;
            string myDate = theCurrentTime.ToShortDateString();
            // Console.WriteLine("");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write an entry on your Journal");
            Console.WriteLine("2. Display all Journal's entryes");
            Console.WriteLine("3. Load a csv file");
            Console.WriteLine("4. Save to a csv file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1") // Write
            {
                Entry theEntry = new Entry();
                myPromptText = thePrompt.GetRandomPrompt();
                Console.WriteLine(myPromptText);
                Console.Write("> ");
                myEntryText = Console.ReadLine();
                theEntry._date = myDate;
                theEntry._promptText = myPromptText;
                theEntry._entryText = myEntryText;
                theJournal.AddEntry(theEntry);
            }
            else if (menuChoice == "2") // Display
            {
                theJournal.DisplayAll();
            }
            else if (menuChoice == "3") // Load
            {
                Console.WriteLine("What is the csv filename (just the name, not the extension)?");
                Console.Write("> ");
                myFileName = Console.ReadLine();
                theJournal.LoadFromFile(myFileName);

            }
            else if (menuChoice == "4") // Save
            {
                Console.WriteLine("What is the csv filename (just the name, not the extension)?");
                Console.Write("> ");
                myFileName = Console.ReadLine();
                theJournal.SaveToFile(myFileName);
            }
            else if (menuChoice == "5") // Quit
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine(" Quiting... Have a good day!");
            }
            else
            {
                Console.WriteLine("Wrong Choice!");
            }
        } while (menuChoice != "5");
    }
}