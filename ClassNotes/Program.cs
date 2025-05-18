using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume.Name = "Jayakar Peddeli";

        Job job1 = new Job
        {
            JobTitle = "Software Engineer",
            Company = "Tech Corp",
            StartYear = 2020,
            EndYear = 2022
        };

        Job job2 = new Job
        {
            JobTitle = "Web Developer",
            Company = "Creative Agency",
            StartYear = 2022,
            EndYear = 2024
        };

        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}
