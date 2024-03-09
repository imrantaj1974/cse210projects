using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    /*static void Main(int[] args)*/
    /* I just want to make sure that int arguments are being passed*/
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Enter your grade");
    /*string is being change to int */
        string gradeReceived = Console.ReadLine();
        int stpercent = int.Parse(gradeReceived);
        /* Console.Write(stpercent); */
        Console.Write($"The grade you entered is {stpercent}");
        string teller = "";
        string status = "";
        if (stpercent >=90)
            {
            teller="A";
            }
        else if (stpercent>=80)
            {
            teller="B";
            status="P";
            }
        else if (stpercent>=70)
            {
            teller="C";
            status="P";
            }
        else if (stpercent>=60)
            {
            teller="D";
            status="P";
            }
        else (stpercent < 60)
            {
            teller="F";
            status="F";
            }
        if ((teller=="A"||teller=="B"||teller=="c"||teller=="D"||) && status ="P")
        {
        Console.Write($"Your Grade is:  {teller} and you have passed");
        }
        else
        {
        Console.Write($"Your Grade is:  {teller} and you have Failed");
        }
        
     }
}