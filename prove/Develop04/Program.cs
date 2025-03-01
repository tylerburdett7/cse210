using System;

class Program
{
    static void Main(string[] args)
    {
        var time = new Activity();

        bool done = false;
        while(!done) {
            Console.Clear();

            int totalTime = time.GetTotalTime();
            if (totalTime >= 1) {
                Console.WriteLine($"You have done {totalTime} seconds of mindfullness activities today! \n");
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a Choice From the Menu: ");

            string input = Console.ReadLine();

            int option = int.Parse(input);

            if (option == 1) {
                var breathing = new BreathingActivity(0, "Breathing");
                breathing.DoActivity();
            }

            else if (option == 2) {
                var reflecting = new ReflectionActivity(0, "Reflection");
                reflecting.DoActivity();
            }

            else if (option == 3) {
                var listing = new ListingActivity(0, "Listing");
                listing.DoActivity();
            }

            else if (option == 4) {
                done = true;
            }

        }   
    }
}