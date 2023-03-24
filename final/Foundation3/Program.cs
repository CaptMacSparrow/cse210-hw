using System;

class Program
{
    static void Main(string[] args)
    {
        //first event
        Address a1 = new Address("81 White St", "New York", "NY", "USA");
        LectureEvent e1 = new LectureEvent("Lecture", "Bob's Lecture", "Really boring", "12/12/24", "5:05PM", a1.GetFullAddress(), "Bobito", 100);
        string Event1dt = e1.GetStandardDetails();
        string Event1fd = e1.GetLectureFullDetails();
        string Event1ds = e1.GetShortDescription();

        Console.WriteLine();
        Console.WriteLine("***Event 1***");
        Console.WriteLine();
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(Event1dt);
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(Event1fd);
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(Event1ds);
        
        //second event
        Address a2 = new Address("90 West St", "New York", "NY", "USA");
        ReceptionEvent e2 = new ReceptionEvent("Reception", "Bill's Wedding", "Less boring", "11/11/23", "6:00PM", a2.GetFullAddress(), "OurWedding@gmail.com");
        string Event2dt = e2.GetStandardDetails();
        string Event2fd = e2.GetReceptionFullDetails();
        string Event2ds = e2.GetShortDescription();
        
        Console.WriteLine();
        Console.WriteLine("***Event 2***");
        Console.WriteLine();
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(Event2dt);
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(Event2fd);
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(Event2ds);

        //third event
        Address a3 = new Address("123 Main St", "Provo", "UT", "USA");
        OutdoorEvent e3 = new OutdoorEvent("Outdoor", "Joe's Gathering", "Should be fun", "6/6/24", "2:30PM", a3.GetFullAddress(), "Sunny");
        string Event3dt = e3.GetStandardDetails();
        string Event3fd = e3.GetOutdoorFullDetails();
        string Event3ds = e3.GetShortDescription();

        Console.WriteLine();
        Console.WriteLine("***Event 3***");
        Console.WriteLine();
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(Event3dt);
        Console.WriteLine();
        Console.WriteLine("FULL DETAILS");
        Console.WriteLine(Event3fd);
        Console.WriteLine();
        Console.WriteLine("SHORT DESCRIPTION");
        Console.WriteLine(Event3ds);

    }
}