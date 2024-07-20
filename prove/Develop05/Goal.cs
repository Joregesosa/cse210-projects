using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string check = IsComplete() ? "[X] " : "[ ] ";
        return check + _shortName + " (" + _description + ")";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}~{_description}~{_points}";
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int SetPoints(int points)
    {
        return _points = points;
    }

}