using System.Runtime.InteropServices;

public class Entry {
    
    public string _prompt;
    public string _response;
    public DateTime _date;

    public string _dayRating;

    public Entry(string prompt, string response, string dayRating) {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
        _dayRating = dayRating;
    }

    public Entry(string prompt, string response, DateTime date, string dayRating) {
        _prompt = prompt;
        _response = response;
        _date = date;
        _dayRating = dayRating;
    }
    
    public void DisplayEntry() {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Day Rating 1-5: {_dayRating}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("---------------------------");
    }
}