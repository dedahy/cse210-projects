using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sqr = SquareNumber(number);
        DisplayResult(name, sqr);
    }
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