using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        Job job2 = new Job();


        job1._jobTitle = "Software Engineer";
        job1._companyName = "MicroSoft";
        job1._companyYear = "2019-2022";


        job2._jobTitle = "Manager";
        // Console.WriteLine($"{job1._jobTitle}");
        // Console.WriteLine($"{job2._jobTitle}");
        
        job1.Display();


        // job2.Display();


        
    }
}