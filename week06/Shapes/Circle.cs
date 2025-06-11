
public class Circle : Shape
{
    private double _radius;

    //Constructor
    public Circle(string color, double radius) : base(color)
    { 
        _radius = radius;
    }

    //Getters and Setters
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    //Method
    public override double GetArea()
    {
        return  _radius * _radius * Math.PI;
    }

}