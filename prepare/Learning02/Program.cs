using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2018;
        job1._endYear = 2021; 
        //{
        //    Console.WriteLine($"{job1._jobTitle} {job1._company}");
        //}
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2023;
        //{
        //  Console.WriteLine($"{job2._jobTitle} {job2._company}");
        //}
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();
        Resume myResume = new Resume();
        myResume._name = "Jake Kiehl";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
        myResume.Display();
    }
}