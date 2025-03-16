public class CheckListGoal : Goal{
    private int _totalToComplete;

    private int _timesCompleted;

    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int bonusPoints, int totalToComplete, int timesCompleted): base(name, description, points) {
        _totalToComplete = totalToComplete;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }

    public CheckListGoal(string[] elements) {
        _name = elements[1];
        _description = elements[2];
        _points = int.Parse(elements[3]);
        _bonusPoints = int.Parse(elements[4]);
        _totalToComplete = int.Parse(elements[5]);
        _timesCompleted = int.Parse(elements[6]);
    }

    public override string GetRepresentation() {
        return $"CheckListGoal`{_name}`{_description}`{_points}`{_bonusPoints}`{_totalToComplete}`{_timesCompleted}";
    }

    public override int SetCompleted()
    {
        _timesCompleted++;
        return _points;
    }

    public override bool IsCompleted()
    {
        if(_timesCompleted >= _totalToComplete) {
            return true;
        }
        else {
            return false;
        }
    }

    public override void Display()
    {
        bool completed = IsCompleted();
        string check = "";
        if (completed == true) {
            check = "✅";
        }
        Console.WriteLine($"[{check}] {_name} ({_description}) -- Currently Completed: {_timesCompleted}/{_totalToComplete}");
    }


}