using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("John Blaze");
        assignment1.SetTopic("Bikes");

        //Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Rick James");
        assignment2.SetTopic("Basketball");
        assignment2.SetTextbookSection("7.3");
        assignment2.SetProblems("8-19");

        //Console.WriteLine(assignment2.GetSummary());
        //Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("Mary Waters");
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Causes of World War II by Mary Waters");

        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}