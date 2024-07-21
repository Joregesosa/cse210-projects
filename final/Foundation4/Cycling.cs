class Cycling : Activity
{
    private double _distance;

    public Cycling(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

}