using System;
using System.Security.Cryptography.X509Certificates;

class Resume
{
    public string _firstName;
    public string _lastName;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}