// Exceeds Core Requirements
//
// To meet the "Showing Creativity and Exceeding Requirements" category, I have implemented
// an activity log feature. This feature tracks the number of times each of the three
// mindfulness activities (Breathing, Reflecting, and Listing) has been completed
// during the current session.
//
// A new option, "4. View Activity Log", has been added to the main menu. When selected,
// this option displays a formatted report showing the completion count for each activity.
//
// As a detail of quality, the log display correctly handles singular and plural forms
// (e.g., "1 time" vs. "2 times") to provide a more polished user experience.
using System;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice;
        int breathingCount = 0;
        int listingCount = 0;
        int reflectingCount = 0;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View Activity Log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if (menuChoice == "1") // Breathing Activity
            {
                breathingCount += 1;
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (menuChoice == "2") // Reflecting Activity
            {
                reflectingCount += 1;
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (menuChoice == "3") // Listing Activity
            {
                listingCount += 1;
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (menuChoice == "4") // Log
            {
                string breathingText = "times";
                string reflectingText = "times";
                string listingText = "times";
                if (breathingCount == 1)
                {
                    breathingText = "time";
                }
                if (reflectingCount == 1)
                {
                    reflectingText = "time";
                }
                if (listingCount == 1)
                {
                    listingText = "time";
                }
                Console.Clear();
                Console.WriteLine("--- Your Activity Log ---");
                Console.WriteLine();
                Console.WriteLine("You have completed:");
                Console.WriteLine($"- Breathing Activity: {breathingCount} {breathingText}");
                Console.WriteLine($"- Reflecting Activity: {reflectingCount} {reflectingText}");
                Console.WriteLine($"- Listing Activity: {listingCount} {listingText}");
                Console.WriteLine();
                Console.Write("Press ENTER to return to the menu.");
                Console.ReadLine();
            }
            else if (menuChoice == "5") // Quit
            {
            }
            else
            {
                Console.WriteLine("Wrong Choice!");
            }
            Console.Clear();
        } while (menuChoice != "5");
    }
}