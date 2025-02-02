using System.IO.Compression;

public class Job {
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public Job() {

    }


    public Job(string jobTitle, string company, int startyear, int endYear) {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startyear;
        _endYear = endYear;
    }
    public void DisplayJobDetails() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}