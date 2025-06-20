
public class Rectangle : Shape
{
	private double _length  = 0;
	private double _width = 0;

	//Constructor 
	public Rectangle(string color, double length, double width) : base(color)
	{ 
		_length = length;
		_width = width;
	}

	//Getters and Setters
	public double GetLength()
	{
		return  _length;
	}
	public void SetLength(double length)
	{
		_length = length;
	}

	public double GetWidth()
	{
		return _width;
	}
	public void SetWidth(double width)
	{
		_width = width;
	}

	//Method
	public override double GetArea()
	{
		return  _length * _width;
	}

}