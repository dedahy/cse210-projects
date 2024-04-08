using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {

         static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            
            return number;
        }

        static int SquareNumber(int number)
        {
            int sqr = number * number;
            
            return sqr;
        }
        static void DisplayResult(string name, int sqr)
        {
            Console.WriteLine($"{name}, the square of your number is {sqr}.");
        }

    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}