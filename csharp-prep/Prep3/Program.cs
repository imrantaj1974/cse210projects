using System;
class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userMagicNumber = -1;
        /*Console.WriteLine("Hello Prep3 World!");*/
        // Console.Write("What is the magic number ?");
        // string magicNumber = Console.ReadLine();
        // int mgcNumber = int.Parse(magicNumber);
        /*Console.WriteLine($"Magical Number is {mgcNumber} ");*/

        Console.Write ("What is your guess? ");
        userMagicNumber = int.Parse(Console.ReadLine());
        // int userMgcNumber = int.Parse(userMagicNumber);
        // while (userMgcNumber != mgcNumber)        
        
        if (userMagicNumber < magicNumber)
            {
                Console.WriteLine("Smaller");
                /*Console.WriteLine($"Smaller {userMgcNumber}");*/
        }
        else if (userMagicNumber > magicNumber)
        {
            /*Console.WriteLine($"Bigger {userMgcNumber}");*/
            Console.WriteLine("Bigger");
        }
        else
        {
            /*Console.WriteLine($"Wow, you guessed it {userMgcNumber}");*/
            Console.WriteLine("You guessed it ! ");

        }
    }
}