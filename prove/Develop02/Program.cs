using System;
using System.IO;
using System.Collections.Generic;

class Journal
{
    static Random randomPrompt = new Random();
    static void Main(string[] args)
    {   
        //welcome message
        Console.WriteLine("Welcome to the Journal Program!");
        //for infinite loop: https://www.geeksforgeeks.org/c-infinite-loop/
        while (true)
        {
            //menu
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following options:");
             Console.WriteLine(" ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            //receive input
            string _selection = Console.ReadLine();
            //error message if input isn't 1-5
            while (_selection != "1" && _selection != "2" && _selection != "3" && _selection != "4" && _selection != "5")
            {
                Console.WriteLine("Invalid response.  Please choose a number between 1 and 5.");
                _selection = Console.ReadLine();
            } 
            
            //switch info: https://www.w3schools.com/cs/cs_switch.php
            switch (_selection)
            {
                case "1":
                    NewEntry();
                    break;
                case "2":
                    ShowJourn();
                    break;
                case "3":
                    LoadJourn();
                    break;
                case "4":
                    SaveJourn();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Journal Program! ");
                    return;
            }
        }
    }

    static List<Entry> journal = new List<Entry>();
    //static list: https://stackoverflow.com/questions/19393481/c-sharp-initialize-a-static-list-in-a-class
    static List<string> prompts = new List<string>()
    {
        "What was a difficult decision that you've had to make today?",
        "Who had a significant impact on you today?",
        "What's a goal you are working towards, and how did you work towards it today?",
        "What did you do today that you felt proud of?",
        "What did you do today that you regret?  How could you have done things differently?",
    };

    //new journal entry method
    static void NewEntry()
    {
        int _promptIndex = randomPrompt.Next(prompts.Count);
        string _prompt = prompts[_promptIndex];
        //give prompt and get response
        Console.WriteLine(_prompt);
        string _response = Console.ReadLine();
        //add date to entry
        DateTime theCurrentTime = DateTime.Now;
        string _dateText = theCurrentTime.ToShortDateString();
        Entry entry = new Entry(_dateText, _prompt, _response);
        journal.Add(entry);
    }

    //show journal entries method
    static void ShowJourn()
    {
        //message if journal is empty
        if (journal.Count == 0)
        {
            Console.WriteLine("There are no entries found in the journal.");
            return;
        }

        foreach (Entry entry in journal)
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._response);
            Console.WriteLine();
        }
    }

    //save journal to a file method
    static void SaveJourn()
    {
        Console.WriteLine("Please enter a filename (including file extension .txt): ");
        string _fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (Entry entry in journal)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._response);
                writer.WriteLine();
            }
        }
    }

    //load journal from a file method
    static void LoadJourn()
    {
        Console.WriteLine("Please enter a filename (including file extension .txt): ");
        string _fileName = Console.ReadLine();
        //clears the journal list of entries
        journal.Clear();
        using (StreamReader reader = new StreamReader(_fileName))
        {
            while (!reader.EndOfStream)
            {
                string _date = reader.ReadLine();
                string _prompt = reader.ReadLine();
                string _response = reader.ReadLine();
                Entry entry = new Entry(_date, _prompt, _response);
                journal.Add(entry);
            }
        }
    }
}