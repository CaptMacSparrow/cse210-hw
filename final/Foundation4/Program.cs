using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2022, 11, 3), 30, 3),
            new CyclingActivity(new DateTime(2022, 11, 4), 45, 20),
            new SwimmingActivity(new DateTime(2022, 11, 5), 30, 40)
        };
    
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummmary());
        }
    }    
}