using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("204 E 5600 S", "MURRAY", "UT", "USA");
        Address address2 = new Address("99-040 KAUHALE ST", "AIEA", "HI", "USA");

        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("Outdoor Gathering", "Outdoor Gathering Description", "10/10/2021", "10:00 AM", address1, "Sunny");

        ReceptionsEvent receptionsEvent = new ReceptionsEvent("Reception", "Reception Description", "10/11/2021", "11:00 AM", address2, "reception@mail.com");

        LecturesEvent lecturesEvent = new LecturesEvent("Lecture", "Lecture Description", "10/13/2021", "1:00 PM", address1, "John Doe", 100);

        Console.Clear();

        Console.WriteLine("Event Marketing Messages - Outdoor Gathering");
        Console.WriteLine(outdoorGatheringEvent.GetShortDetails() + "\n");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails() + "\n");
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails() + "\n");

        Console.WriteLine("Event Marketing Messages - Receptions");
        Console.WriteLine(receptionsEvent.GetShortDetails() + "\n");
        Console.WriteLine(receptionsEvent.GetStandardDetails() + "\n");
        Console.WriteLine(receptionsEvent.GetFullDetails() + "\n");

        Console.WriteLine("Event Marketing Messages - Lectures");
        Console.WriteLine(lecturesEvent.GetShortDetails() + "\n");
        Console.WriteLine(lecturesEvent.GetStandardDetails() + "\n");
        Console.WriteLine(lecturesEvent.GetFullDetails() + "\n");


    }
}