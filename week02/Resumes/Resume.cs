using System;

public class Resume
{
    public string _resumeName;
    public List<Job> _jobs = new List<Job>();

    public void DislayResume()
    {
        Console.WriteLine($"Name: {_resumeName}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }

    }



}