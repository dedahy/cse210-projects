using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {   
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
        /*
        Assignment studentInfo = new Assignment("Dedahy Jean Ombilahy", "Division");
        MathAssignment examen = new MathAssignment("Tody Jean Marc", "Division", "Section 7.3", "Problems 8-19");
        WritingAssignment assignment = new WritingAssignment("Bernadia Jessica", "Geography", "World War II");

        string student = studentInfo.GetStudentName();
        string summary = examen.GetSummary();
        string topic = examen.GetHomeworkList();
        string title = assignment.GetWrittingInformation();
        //student Name

        Console.WriteLine(student);

        //Math Class

        Console.WriteLine(student);
        Console.WriteLine(topic);

        //Writing Class

        Console.WriteLine(student);
        Console.WriteLine(title);

        //Summary

        Console.WriteLine(student);
        Console.WriteLine(summary);

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
        */
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}