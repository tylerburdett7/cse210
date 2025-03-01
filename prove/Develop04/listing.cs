using System.Diagnostics;
public class ListingActivity : Activity{
    
    List<string> _prompts = new List<string>{};

    public ListingActivity(int duration, string name): base(duration, name) {
        _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }


    public void DoActivity() {

        ShowWelcome();
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int duration = GetDuration();
        ShowGetReady();

        var timeTrack = new Stopwatch();
        timeTrack.Start();

        string prompt = GetRandomPrompt(_prompts);
        DisplayPrompt(prompt);

        Console.Write("You may begin in ");
        ShowCountDown(5);
        Console.WriteLine("\n");

        int entryCount = 0;

        while (timeTrack.Elapsed < TimeSpan.FromSeconds(duration)) {
            Console.Write("> ");
            Console.ReadLine();
            Console.WriteLine();

            entryCount++;
            bool done = IsThereTime(timeTrack, duration);
            if (done == false) {
                break;
            }
        }

        Console.WriteLine($"You listed {entryCount} items!!\n");
        DisplayWellDone();

        UpdateTotalTime(duration);

    }
}

