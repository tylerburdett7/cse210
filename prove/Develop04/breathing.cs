using System.Diagnostics;

public class BreathingActivity : Activity {



    public BreathingActivity(int duration, string name): base(duration, name) {  
    
    }

    public void DoActivity() {

        ShowWelcome();
        Console.WriteLine("This activity will help you relax by slowing down your breathing. Clear your mind and focus on breathing");

        int duration = GetDuration();
        Console.Clear();

        ShowGetReady();

        var timeTrack = new Stopwatch();

        while (timeTrack.Elapsed < TimeSpan.FromSeconds(duration)) {
            timeTrack.Start();

            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }
        Console.WriteLine("\n");
        DisplayWellDone();

        UpdateTotalTime(duration);


    }
}