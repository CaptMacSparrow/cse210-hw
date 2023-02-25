using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        //Activity a0 = new Activity();
        
        //BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0, "Breathe in...", "Breathe out...");
        //a1.SetName("Breathing Activity");
        //a1.SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    
        //ReflectionActivity a2 = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        //a2.SetName("Reflection Activity");
        //a2.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        //ListingActivity a3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, new List<string>());
        //a3.SetName("Listing Activity");
        //a3.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        //Console.WriteLine(a0.Duration());

        //Console.WriteLine("Menu Options");
        //while (true)
        //{
        Console.WriteLine();
        Console.WriteLine("Welcome to the Mindfulness Application.");
        Console.WriteLine();
        Console.WriteLine("Menu: ");
        Console.WriteLine();
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.WriteLine("Please select an option from the menu: ");
        Console.WriteLine();

        string input = Console.ReadLine();
        
        while (input != "1" && input != "2" && input != "3" && input != "4")
        {
            Console.WriteLine("Invalid response.  Please enter a number between 1 and 4. ");
            input = Console.ReadLine();
        }

        Activity activity;
        switch (input)
        {
            case "1":
                activity = new BreathingActivity();
                Console.WriteLine();
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine();
                break;
            case "2":
                activity = new ReflectionActivity();
                Console.WriteLine();
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine();
                break;
            case "3":
                activity = new ListingActivity();
                Console.WriteLine();
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine();
                break;
            //case "4":
            //    Console.WriteLine("Thank you for using the Program! ");
            //    break;
                default:
                    activity = null;
                    break;
        }

        if (activity != null)
        {
            activity.Start();
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for using the Program! ");
    }
}