
public abstract class Activity
{
	private string _date; 
	private int _length;

	public Activity(int length)
	{
		_length = length;
		_date = DateTime.Now.ToString("dd-MMM-yyyy");
	}


	public string GetDate()
		{ return _date; }
	public int GetLength()
	{ return _length; }

	public abstract double Distance();
	public abstract double Speed();
	public abstract double Pace();

	public string GetSummary()
	{
		return ($" ({GetLength()} min) - Distance {Distance()} miles, " +
			$"Speed {Speed()} mph, Pace: {Pace()} min per mile.");
	}
}