using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Customer Service";
        job1._company = "Webhelp";
        job1._startYear = 2020;
        job1._endYear = 2024;
        
        Resume myresume = new Resume();
        myresume._name = "Aîcha";

        myresume._jobs.Add(job1);
        myresume.Display();
    }

}