class Swimming : Activity
{

    private double _distance;

    public Swimming(string date, int length) : base(date, length)
    {
        _distance = 50;
    }

    public override double GetDistance()
    {
        return _length * _distance / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

}