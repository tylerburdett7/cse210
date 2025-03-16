public class EternalGoal : Goal {
    



    public EternalGoal(string name, string description, int points): base(name, description, points) {

    }

    public EternalGoal(string[] elements) {
        _name = elements[1];
        _description = elements[2];
        _points = int.Parse(elements[3]);
    }


    public override string GetRepresentation() {
        return $"EternalGoal`{_name}`{_description}`{_points}`";
    }

    public override int SetCompleted()
    {
        return _points;
    }

    public override bool IsCompleted()
    {
        throw new NotImplementedException();
    }

    public override void Display()
    {
        Console.WriteLine($"[] {_name} ({_description})");
    }


}