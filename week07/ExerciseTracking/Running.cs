
public class Running : Activity
{
    private double _swimmingLaps;
    private double _distance;
    private double _minutes;
    //Constructor 
    public Running(int length, double swimming_laps, double distance, double minutes) : base(length) 
    {
        _swimmingLaps = swimming_laps;
        _distance = distance;
        _minutes = minutes;
    }
    // Getters
    public double GetSwimmingLaps()
    { return _swimmingLaps; }
    public double GetDistance()
    { return _distance; }
    public double GetMinutes()
    { return _minutes; }

    //Methods override
    public override double Distance()
    {
        return _swimmingLaps * 50 / 1000 * 0.62;
    }

    public override double Speed()
    {
        return (_distance / _minutes) * 60;
    }
    public override double Pace()
    {
        return 60 / Speed();
    }


}