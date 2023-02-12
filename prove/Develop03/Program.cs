using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s1 = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine(s1.ToString());
        Console.WriteLine(s1.GetText());

        string script1 = (s1.GetText());
        ScriptureWord sw1 = new ScriptureWord(script1);
    }
}