using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("1254 E timmy Street", "Inkom", "Idaho");
        var outdoor = new Outdoor("75 degrees, sunny", "timmy's birthday extravaganza", "an exciting day filled with love for timmy", "5/23/25", "2:00 PM", address1, "Outdoor Activity");
        
        Console.WriteLine("Full Details:");
        outdoor.DisplayFullDetails();
        Console.WriteLine("\n\nStandard details:");
        outdoor.DisplayStandardDetails();
        Console.WriteLine("\n\nShort description:");
        outdoor.DisplayShortDescription();

        var address2 = new Address("1343 N Main Street", "Las Vegas", "Nevada");
        var lecture = new Lecture("Tyler Burdett", 60, "When to spend your v-bucks", "An in depth lecture about the importance and benefits of spending your v-bucks responsibly", "7/9/25", "7:00 PM", address2, "Lecture");
        
        Console.WriteLine("\n\nFull Details:");
        lecture.DisplayFullDetails();
        Console.WriteLine("\n\nStandard details:");
        lecture.DisplayStandardDetails();
        Console.WriteLine("\n\nShort description:");
        lecture.DisplayShortDescription();

        var address3 = new Address("1674 E 1300 N", "Layton", "Utah");
        var reception = new Reception("tylerburdett@gmail.com", "Tyler and future wife awesome wedding reception", "yep he's planning it before he's even met the girl", "nobody knows but lets hope its before 2028", "5:00 PM", address3, "Reception");

        Console.WriteLine("\n\nFull Details:");
        reception.DisplayFullDetails();
        Console.WriteLine("\n\nStandard details:");
        reception.DisplayStandardDetails();
        Console.WriteLine("\n\nShort description:");
        reception.DisplayShortDescription();
    }
}