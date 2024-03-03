using System;

class Program
{
    static void Main(string[] args)
    {           
        
        string decision = "";
        do
        {

            Random randomGenerator = new Random();
            float magic_number = randomGenerator.Next(1, 100);
            float guess = 0;
            int count= 0;
        
            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                guess = float.Parse(Console.ReadLine());

                count++;

                if (guess < magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"Your number of guess is {count}.");

        Console.Write("Would you still like to continue?");
        decision = Console.ReadLine().ToLower();

        }
        while(decision == "yes");
        Console.WriteLine("Thank you for taking time to play my guess number game.");
    }
        
}