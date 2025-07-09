using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is you grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        string signal;
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            signal = "+";
        }
        else if (lastDigit < 3)
        {
            signal = "-";
        }
        else
        {
            signal = "";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}{signal}");

        if (grade >= 70)
        {
            Console.WriteLine("Gongratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("You need to study more next time! You din't pass the Course!");
        }

    }
}