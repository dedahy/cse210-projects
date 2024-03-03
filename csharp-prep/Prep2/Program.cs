using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        string letter ="";
        Console.Write("What is your grade percentage? ");        
        float grade = float.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            
            if (grade>=93 && grade <= 100)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
        }

        else if (grade >= 80)
        {
            if (grade >= 87 && grade < 90)
            {
                letter = "B+";
            }
            else if (grade >= 83 && grade < 87)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }
        }

        else if (grade >= 70)
        {
             if (grade >= 77 && grade < 80)
            {
                letter = "C+";
            }
            else if (grade >= 73 && grade < 77)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }
        }

        else if (grade >= 60)
        {
             if (grade >= 67 && grade > 70)
            {
                letter = "D+";
            }
            else if (grade >= 63 && grade < 67)
            {
                letter = "D";
            }
            else
            {
                letter = "D-";
            }
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (grade >= 70)
        {
            Console.WriteLine("congratulations!\nYou paased.");
        }
        else
        {
            Console.WriteLine("You need to work hard about C# conditions to help you.");
        }        
    }
}