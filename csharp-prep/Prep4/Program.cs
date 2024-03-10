using System;
using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber!=0)
        {
        Console.Write("Enter a list of numbers, type 0 when finished : ");
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);
        if(userNumber !=0)
        {
            numbers.Add(userNumber);
        }
        }
        // Caluculate the sum
        int sum = 0;
        foreach (int number in numbers)
            {
                sum+=number;
            }

            Console.WriteLine($"The sum is : {sum}");

            // Calculating Average, the variable is set to be float in order to get a decimal result.
            float average = ((float)sum) / numbers.Count;
        // Console.WriteLine("Hello Prep4 World!");
            Console.WriteLine($"The average is : {average}");

            // Finding Maximum number
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
        Console.WriteLine($"Max number is : {max}");
 
            // Finding Smallest number
            int smallest = numbers[0];
            foreach (int number in numbers)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }
        Console.Write($"Smallest number is : {smallest}");
    }
}