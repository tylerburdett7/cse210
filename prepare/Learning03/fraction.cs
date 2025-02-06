using System.Diagnostics;

public class fraction {
    private int _top;
    private int _bottom;

    public fraction() {
        _top = 0;
        _bottom = 0;
    }
    
    public fraction(int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop() {
        return _top;
    }

    public void SetTop(int top) {
        _top = top;
    }

    public int GetBottom() {
        return _bottom;
    }

    public void setBottom(int bottom) {
        _bottom = bottom;
    }

    public string GetFraction() {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue() {
        double value = (double)_top / _bottom;
        return value;
    }
}