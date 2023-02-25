public class ListingActivity : Activity
{
    // The list of prompts
    public List<string> Prompts { get; set; }

    // Override the RunActivity method from the base class
    public override void RunActivity()
    {
        // Show the starting message
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds
        System.Threading.Thread.Sleep(3000);

        // Get a random prompt
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        // Give them a few seconds to think
        System.Threading.Thread.Sleep(Duration * 1000);

        // Ask them to start listing
        Console.WriteLine("Start listing...");
        int itemCount = 0;
        while (Duration > 0)
        {
            string input = Console.ReadLine();
            itemCount++;
            Duration--;
        }

        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds and listed {itemCount} items.");
        Console.WriteLine("Thank you for participating.");
    }
}