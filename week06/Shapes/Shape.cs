
public abstract class Shape
{
    private string _color;

    //Constructor
    public Shape(string color)
    { 
        _color = color;
    }

    //Getter and Setter
    public string GetColor()
    { 
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    //Method 
    public abstract double GetArea();
 
}