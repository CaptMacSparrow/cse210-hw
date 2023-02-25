using System;

class ListingActivity : Activity
{
    protected override void RunActivity()
    {
        List<string> items = new List<string>();
        for (int i = 0; i < _duration; i++)
        {
            Console.Write("Listing ");
            for (int j = 0; j < i % 3 + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Pause(1);
            
            if (i % 10 == 0)
            {
                Console.WriteLine("Write down some thoughts: ");
                string item = Console.ReadLine();
                items.Add(item);
            } 
        }

        Console.WriteLine("Here are your thoughts that you listed: ");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }
    }
    //private List<string> _listingPrompts = new List<string>()
    //{
    //    "Who are people that you appreciate?",
    //    "What are personal strengths of yours?",
    //    "Who are people that you have helped this week?",
    //    "When have you felt the Holy Ghost this month?",
    //    "Who are some of your personal heroes?"
    //};

    //public ListingActivity(string name, string description, int duration, List<string> listingPrompts)
    //    : base(name, description, duration)
    //{
    //    _listingPrompts = listingPrompts;
    //}
    //public List<string> GetListingPrompts()
    //{
    //    return _listingPrompts;
    //}
    //public void SetListingPrompts(List<string> listingPrompts)
    //{
        
    //}
}