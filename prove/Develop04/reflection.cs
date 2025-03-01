using System.Diagnostics;
using Microsoft.VisualBasic;
public class ReflectionActivity : Activity {
    private List<string> _prompts = new List<string> {};
    private List<string> _reflectionQuestions = new List<string> {};



    public ReflectionActivity(int duration, string name): base(duration, name) {
        _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

        _reflectionQuestions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?, How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }
    public ReflectionActivity(List<string> prompts, List<string> reflectionQuestions, int duration, string name): base(duration, name) {
        _prompts = prompts;
        _reflectionQuestions = reflectionQuestions;
    }

    public void DisplayReflectionQuestionByIndex(List<string> reflectionQuestions, int index) {
        Console.WriteLine(reflectionQuestions[index]);
    }

    public void DisplayReflectionProcess(Stopwatch time, int duration) {
        bool timeLeft = true;

        for (int i = 0; i < _reflectionQuestions.Count; i++) {            
            DisplayReflectionQuestionByIndex(_reflectionQuestions, i);
            ShowLoading(10);

            timeLeft = IsThereTime(time, duration);
            if (timeLeft == false) {
                break;
            }
        }

    }


    public void DoActivity() {

        ShowWelcome();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        int duration = GetDuration();
        ShowGetReady();

        var timeTrack = new Stopwatch();
        timeTrack.Start();

        while (timeTrack.Elapsed < TimeSpan.FromSeconds(duration)) {
            
            Console.WriteLine("Consider the Following Prompt:\n");

            string randomPrompt = GetRandomPrompt(_prompts);
            DisplayPrompt(randomPrompt);

            Console.WriteLine("When you have something in mind, press enter to continue.");

            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
            ShowCountDown(4);
            Console.WriteLine();

            DisplayReflectionProcess(timeTrack, duration);

            DisplayWellDone();

            UpdateTotalTime(duration);

        }

    }


}

