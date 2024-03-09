using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello Prep3 World!");*/
        Console.WriteLine("What is the magic # ");
        string magicNumber = Console.ReadLine();
        int mgcNumber = int.Parse(magicNumber);

        Console.WriteLine("Guess what is the magic # ?");
        string userMagicNumber = Console.ReadLine();
        int userMgcNumber = int.Parse(userMagicNumber);
        
        if (userMgcNumber < mgcNumber)
            {
                Console.WriteLine($"Your proposed number is smaller {userMgcNumber}");
        }
        else if (userMgcNumber > mgcNumber)
        {
            Console.WriteLine($"Your proposed number is bigger {userMgcNumber}");
        }
        else
        {
            Console.WriteLine($"Wow, you guessed it {userMgcNumber}");
        }

    }
}