using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int number = -1;
        int sum = 0;
        double average;
        int largest = 0;
        int smallest = 9999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int numb in numbers)
        {
            sum += numb;
            if (numb > largest)
            {
                largest = numb;
            }
            if (numb > 0 && numb < smallest)
            {
                smallest = numb;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}