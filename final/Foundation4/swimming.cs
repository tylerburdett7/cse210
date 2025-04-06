public class Swimming : Activity {
    private int _laps;

    public Swimming(int laps, string date, int length): base(date, length) {
        _laps = laps;
    }

    public override double GetDistance() {
      return _laps * 0.031;
    }

    public override double GetSpeed() {
        return GetDistance() / _length * 60;
    }

    public override double GetPace() {
        return _length / GetDistance();
    }
}