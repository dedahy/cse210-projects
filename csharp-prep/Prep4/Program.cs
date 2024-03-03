using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        float number = -1;
        List<float>numbers = new List<float>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number !=0)
        {
            
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        float sum = 0;
        foreach(float nbr in numbers)
        {
            sum +=nbr;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        float max = numbers[0];

        foreach (float nbr in numbers)
        {
            if (nbr > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = nbr;
            }
        }

        Console.WriteLine($"The max is: {max}");
        //
    }
}