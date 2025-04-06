using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        var running = new Running(12.0, "05 July 2025", 45);
        activities.Add(running);

        var swimming = new Swimming(30, "06 May 2025", 10);
        activities.Add(swimming);

        var cycling = new Cycling(26, "24 Aug 2025", 30);
        activities.Add(cycling);

        foreach(Activity Activity in activities) {
            string summary = Activity.GetSummary();
            Console.WriteLine(summary);
        }
    }
}