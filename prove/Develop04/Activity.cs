using System;

abstract class Activity
{
    //private string _name;
    //private string _description;
    protected int _duration;

    public void Start()
    {
        ShowStartMessage();
        Pause(3);
        RunActivity();
        Pause(3);
        ShowEndMessage();
    }

     protected abstract void RunActivity();
     
     protected void Pause(int seconds, bool showTimer = true)
    {
        if (showTimer)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write("\r{0} ", new string(' ', Console.WindowWidth - 1));
                Console.Write("\r{0} seconds remaining. ", i);
                Thread.Sleep(1000);
            }
            Console.Write("\r{0}\r", new string(' ', Console.WindowWidth - 1));
        }
        else
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
     protected void ShowStartMessage()
    {
        Console.WriteLine($"Starting {GetType().Name}... ");
        Console.WriteLine();
        Console.Write("In seconds, how long would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Get ready. ");
        for (int i = 0; i < 30; i++)
        {
            Console.Write(" +");
            Thread.Sleep(200);
        }
        Console.WriteLine();
        Pause(3);
    }

    protected void ShowEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Congratulations!  You completed {GetType().Name} with {_duration} second breaths.");
    }

    
    
    //public Activity(string name, string description, int duration)
    //{
    //    _name = name;
    //    _description = description;
    //    _duration = duration;
    //}
    
    //public string GetName()
    //{
    //    return _name;
    //}
    //public void SetName(string name)
    //{
    //    _name = name;
    //}

    //public string GetDescription()
    //{
    //    return _description;
    //}
    //public void SetDescription(string description)
    //{
    //    _description = description;
    //}

    //public int GetDuration()
    //{
    //    return _duration;
    //}
    //public void SetDuration(int duration)
    //{
    //    _duration = duration;
    //}

    //public abstract void Start();

    
    //public int Duration()
    //{
    //    Console.Write("How long would you like this activity to be (in seconds)? ");
    //    int duration;
        
    //    while (!int.TryParse(Console.ReadLine(), out duration))
    //    {
    //        Console.Write("Please enter a valid number: ");
    //    }
    //    return duration;
    //}
}