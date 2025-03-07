using System.Formats.Asn1;

public class Rectangle : Shape {

    private double _width;
    private double _length;

    public Rectangle(double width, double length, string color): base(color) {
        _width = width;
        _length = length;

    }

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}