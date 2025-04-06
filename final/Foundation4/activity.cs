public abstract class Activity {

    protected string _date;
    protected int _length; //in minutes
    // private int _distance;
    // private int _speed;
    // private int _pace;

    public Activity(string date, int length) {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary() {
        string activityType = this.GetType().Name;
        return $"{_date} {activityType} ({_length} min)- Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}