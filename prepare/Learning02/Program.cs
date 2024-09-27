using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Softwarae engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;
        
        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Softwarae engineer";
        job2._startYear = 2027;
        job2._endYear = 2029;
        
        Resume bridger = new Resume();
        bridger._name = "Bridger";
        bridger._jobs.Add(job1);
        bridger._jobs.Add(job2); 

        bridger.Display();
    }
}
