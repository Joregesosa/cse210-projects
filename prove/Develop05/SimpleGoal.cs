using System;

public class SimpleGoal : Goal
{
    private bool _iscomplete;
    public SimpleGoal(string shortName, string description, int points, bool iscomplete) : base(shortName, description, points)
    {
        _iscomplete = iscomplete;
    }

    public override void RecordEvent()
    {
        _iscomplete = true;
    }

    public override bool IsComplete()
    {
        return _iscomplete;
    }

    public override string GetStringRepresentation()
    {
        return 1 + "~" + base.GetStringRepresentation() + "~" + _iscomplete;
    }
 
}