
public class Square : Shape
{
    private double _side = 0;

    //Constructor
    public Square(string color, double side) : base(color)
    { 
        _side = side;
    }

    //Getters and Setters 
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }

    //Method
    public override double GetArea()
    {
        return _side * _side;
    }

}