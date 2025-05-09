using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume.Name = "Jayakar Peddeli";

        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.Company = "Tech Corp";
        job1.StartYear = 2020;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.JobTitle = "Web Developer";
        job2.Company = "Creative Agency";
        job2.StartYear = 2022;
        job2.EndYear = 2024;

        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}
