using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Sales Administration Coordinator";
       job1._company = "ITECRA";
       job1._startYear = 2017;
       job1._endYear = 2024;

       Job job2 = new Job();
       job2._jobTitle = "TetraPak equipment manteinance";
       job2._company = "Fecovita";
       job2._startYear = 2016;
       job2._endYear = 2017;

       Resume resume1 = new Resume();
       resume1._name = "Matias Pastran";

       resume1._jobs.Add(job1);
       resume1._jobs.Add(job2);

       resume1.Display();

    }
}