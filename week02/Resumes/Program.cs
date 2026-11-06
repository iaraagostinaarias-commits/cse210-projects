using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2018;
        job2._endYear = 2026;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Richard Parker";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // string b = myResume._jobs[0]._jobTitle;
        // Console.WriteLine(b);
        myResume.DisplayResume();
    }
}