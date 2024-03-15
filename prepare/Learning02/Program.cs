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
        // job1._companyYear = "2019-2022";
        job1._companyStartYear = 2019;
        job1._companyEndYear = 2022;

        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._companyStartYear = 2022;
        job2._companyEndYear = 2023;

        // job2._companyYear = "2022-2023";

        // Console.WriteLine($"{job1._jobTitle}");
        // Console.WriteLine($"{job2._jobTitle}");
        Resume mineResume = new Resume();
        mineResume._name = "Allison Rose";
        mineResume._jobs.Add(job1);
        mineResume._jobs.Add(job2);
        mineResume.Display();

        // job1.Display();

        // job2.Display();

        
    }
}