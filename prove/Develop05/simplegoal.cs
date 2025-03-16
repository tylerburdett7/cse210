public class SimpleGoal : Goal{
    private bool _completed;

    public SimpleGoal(string name, string description, int points, bool completed): base(name, description, points) {
        _completed = completed;
    }
    
    public SimpleGoal(string[] elements) {
        _name = elements[1];
        _description = elements[2];
        _points = int.Parse(elements[3]);
        _completed = bool.Parse(elements[4]);
    }
    public override string GetRepresentation() {
        return $"SimpleGoal`{_name}`{_description}`{_points}`{_completed}";
    }

    public override int SetCompleted() {
        _completed = true;
        return _points;
    }

    public override bool IsCompleted() => _completed; 

    public override void Display() {
        bool completed = IsCompleted();
        string check = "";
        if (completed == true) {
            check = "✅";
        }
        Console.WriteLine($"[{check}] {_name} ({_description})");
    }


    public override int GetGoalPoints() {
        return _points;
    }


}