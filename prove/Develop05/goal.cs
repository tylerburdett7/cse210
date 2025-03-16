public abstract class Goal {
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal() {
        _name = "";
        _description = "";
        _points = 0;
    }
    public Goal(string name, string description, int points) {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract bool IsCompleted();

    public abstract int SetCompleted();

    public virtual int GetGoalPoints() {
        int points = 0;
        return points;
    }

    public abstract string GetRepresentation(); //give all data as one string so it can be saved. 
    public void SaveGoal(string filepath) {
        string goalRepresentation = GetRepresentation();

        using (StreamWriter outputFile = new StreamWriter(filepath, append: true)) {
            outputFile.WriteLine(goalRepresentation);
        }
    }

    public abstract void Display();

    public void DisplayName() {
        Console.WriteLine(_name);
    }
    

}