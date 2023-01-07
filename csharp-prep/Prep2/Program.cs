using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        if (percentage%10 >= 7)
        {
            sign = "+";
        }
        else if (percentage%10 < 3)
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
            {
                sign = "";
            }
        else if (letter == "F" && sign == "+")
            {
                sign = "";
            }
        else if (letter == "F" && sign == "-")
            {
                sign = "";
            }    

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations!  You passed.");
        }
        else
        {
            Console.WriteLine("Sorry.  You should study more next time.");
        }
    }
}