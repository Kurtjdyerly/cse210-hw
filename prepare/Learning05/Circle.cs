public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) :base(color)
    {
        _color = color;
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = 3.1415 * _radius  * _radius;
        return area;
    }
}