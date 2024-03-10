using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();

        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);

    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program !");
        }

    static string PromptUserName()
        {
            Console.Write("Enter Your Name : ");
            string userName = Console.ReadLine();

            return userName;
        }

    static int PromptUserNumber()
        {
            Console.Write("Enter Your Favorite Number : ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }
    static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }

static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your Number is {square}");
     }

}