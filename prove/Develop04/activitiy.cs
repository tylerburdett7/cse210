using System.Diagnostics;

public class Activity {
    private int _duration;
    private string _name;

    private static int _totalTime;
    public Activity() {
        _duration = 0;
    }

    public Activity(int duration, string name) {
        _duration = duration;
        _name = name;
    }

    public int GetDuration() { //does not return. you're just changing the variable value 
        Console.Write("How long would you like the activity to be? (in seconds): ");
        string input = Console.ReadLine();
        _duration = int.Parse(input); //parse this 
        return _duration;
    }
    public void ShowLoading(int time) {

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed < TimeSpan.FromSeconds(time)) {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
        stopwatch.Stop();
        Console.WriteLine();
    }

    public void ShowWelcome() {
        Console.WriteLine($"\nWelcome to the {_name} activity! ");
    }

    public void ShowGetReady() {
        Console.Clear();
        Console.WriteLine("Get Ready.....");
        ShowLoading(4);
    }
    public void ShowCountDown(int time) {
        for (int i = time; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }

    public string GetRandomPrompt(List<string> prompts) {
    Random random = new Random();
    int randomInRange = random.Next(0, prompts.Count);
    return prompts[randomInRange];
    }


    public void DisplayPrompt(string randomPrompt) {
        Console.WriteLine($"-- {randomPrompt} --\n");
    }

    public bool IsThereTime(Stopwatch time, int duration) {
        if (time.Elapsed < TimeSpan.FromSeconds(duration)) {
            return true;
        }
        else {
            return false;
        }
    }

    public void DisplayWellDone() {
        Console.WriteLine("Well Done!!");
        
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity");
        ShowLoading(4);
    }
    

    public void UpdateTotalTime(int duration) {
        _totalTime += duration;
    }

    public int GetTotalTime() {
        return _totalTime;
    }



}