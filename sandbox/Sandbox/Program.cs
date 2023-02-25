using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine();
            // Display menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu:");
            Console.WriteLine();

            // Get user input
            string input = Console.ReadLine();

            // Validate input
            while (input != "1" && input != "2" && input != "3" && input!= "4")
            {
                Console.Write("Invalid input. Please select an activity: ");
                input = Console.ReadLine();
            }

            //if the user wants to quit
            if (input == "4")
            {
                Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                return;
            }

            // Create activity based on user input
            Activity activity;
            switch (input)
            {
                case "1":
                    activity = new BreathingActivity();
                    Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    Console.WriteLine("This activity will help you reflect on a past experience that was meaningful to you. Choose one of the following prompts and spend the duration reflecting on it.");
                    break;
                case "3":
                    activity = new ListingActivity();
                    Console.WriteLine("This activity will help you clear your mind by listing out everything that comes to mind. Start by focusing on your breath and letting thoughts come and go. When a thought sticks, write it down and return to focusing on your breath.");
                    break;
                default:
                    activity = null;
                    break;
            }

            // Run activity
            if (activity != null)
            {
                activity.Run();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
        }
    }

    abstract class Activity
    {
        protected int duration;

        public void Run()
        {
            DisplayStartingMessage();
            Pause(3);
            DoActivity();
            Pause(3);
            DisplayEndingMessage();
            Pause(3);
        }

       protected void DisplayStartingMessage()
{
    Console.WriteLine("Starting " + GetType().Name + "...");
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like for your session? ");
    duration = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Get ready");
    for (int i = 0; i < 30; i++)
    {
        Console.Write(" +");
        Thread.Sleep(200);
    }
    Console.WriteLine();
    Pause(3);
}


        protected abstract void DoActivity();

        protected void DisplayEndingMessage()
        {
            Console.WriteLine("Good job! You completed " + GetType().Name + " for " + duration + " seconds.");
        }

        protected void Pause(int seconds, bool displayTimer = true)
{
    if (displayTimer)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write("\r{0} ", new string(' ', Console.WindowWidth - 1));
            Console.Write("\r{0} seconds remaining", i);
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

    }

    class BreathingActivity : Activity
    {
        protected override void DoActivity()
        {
            
            for (int i = 0; i < duration; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Breathe in...");
                }   
                else
                {
                    Console.WriteLine("Breathe out...");
                }
                Pause(3);
            }
        }
    }

    class ReflectionActivity : Activity
    {
        private static List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
        };
           

    protected override void DoActivity()
    {
        
        int promptIndex = new Random().Next(prompts.Count);
        Console.WriteLine(prompts[promptIndex]);

        for (int i = 0; i < duration; i++)
        {
            Console.Write("Reflecting");
            for (int j = 0; j < i % 3 + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Pause(1);
        }

        Console.WriteLine("Now, answer one of the following questions to help deepen your reflection:");
        int questionIndex = new Random().Next(questions.Count);
        Console.WriteLine(questions[questionIndex]);
        string response = Console.ReadLine();
        Console.WriteLine("Thank you for your reflection!");
    }
}

class ListingActivity : Activity
{
    protected override void DoActivity()
    {
       
        List<string> items = new List<string>();
        for (int i = 0; i < duration; i++)
        {
            Console.Write("Listing");
            for (int j = 0; j < i % 3 + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Pause(1);

            if (i % 10 == 0)
            {
                Console.WriteLine("Write down any thoughts that stuck with you:");
                string item = Console.ReadLine();
                items.Add(item);
            }
        }

        Console.WriteLine("Here are the items you listed:");
        foreach (string item in items)
        {
            Console.WriteLine("- " + item);
        }
    }
}
}