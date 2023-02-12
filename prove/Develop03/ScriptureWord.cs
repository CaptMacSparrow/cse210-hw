using System;

class ScriptureWord
{
    private string _words;
    private Scripture _script;
    private string _choice;
    private int _counter;
    private string _underscores;
    //private int _wordLength;
    public ScriptureWord(string script)
    {
        string input = script;
        string[] words = input.Split(" ");
    
        do
        {
            Console.WriteLine("Press Enter to hide some (more) words.  Type quit if finished.");
            string choice = Console.ReadLine();

            if (choice == "quit")
            {
                return;
            }
                
            Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "_____")    
                    if (random.Next(2) == 0)
                    {
                    //    int _wordLength = words[i].Length;
                    //    Console.WriteLine(_wordLength);
                        for (int j = 0; j < words[i].Length; j++)
                        {
                            _underscores = _underscores + "_";
                        }
                        words[i] = _underscores; //"_____"
                        _underscores = "";
                    }
            }
            
            Console.WriteLine(string.Join(" ", words));

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Substring(0, 1) == "_")
                {
                    _counter = _counter + 1;
                }
            }
            
            if (_counter == words.Length)
            {
                return;
            }
            _counter = 0;

        } while (_choice != "quit");
    }
}