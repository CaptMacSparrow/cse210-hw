using System;

class ReflectionActivity : Activity
{
    private static List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        };
        //Random random = new Random();
        //return _reflectionPrompts[random.Next(_reflectionPrompts.Length)];
    
    //public void SetReflectionPrompts(List<string> reflectionPrompts)
    //{
    //    _reflectionPrompts = reflectionPrompts;
    //}
    private static List<string> _reflectionQuestions = new List<string>
    {  
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        };
    
    protected override void RunActivity()
    {
        int promptIndex = new Random().Next(_reflectionPrompts.Count);
        Console.WriteLine(_reflectionPrompts[promptIndex]);

        for (int i = 0; i < _duration; i++)
        {
            Console.Write("Reflecting");
            for (int j = 0; j < i % 3 + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            Pause(1);
        }

        Console.WriteLine("Now, please respond to the following questions: ");
        int questionIndex = new Random().Next(_reflectionQuestions.Count);
        Console.WriteLine(_reflectionQuestions[questionIndex]);
        string response = Console.ReadLine();
        Console.WriteLine("Thank you for reflecting. ");
    }
    
    //public List<string> GetReflectionQuestions()
    //{
    //    return _reflectionQuestions;
    //}
    //public void SetQuestions(List<string> reflectionQuestions)
    //{
    //    _reflectionQuestions = reflectionQuestions;
    //}
    //public string RunReflectionActivity()
    //{
    //    return _reflectionPrompts;
    //}
}
