using System;

class Program
{
    /*static void Main(string[] args)*/
    static void Main(int[] args)
    /* I just want to make sure that int arguments are being passed*/
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Enter your grade");
        int gradeReceived = Console.ReadLine();
        Console.WriteLine($"The grade you entered is" {gradeReceived});
    }
}