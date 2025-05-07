using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2023;
        job1._startYear = 2015;
        // job1.Display();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Architect";
        job2._startYear = 2017;
        job2._endYear = 2025; 
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
        
    }
}