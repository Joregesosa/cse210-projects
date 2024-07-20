using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;

    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete())
        {
            SetPoints(GetPoints() + _bonus);
        }
    }

    public override bool IsComplete()
    {

        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + " -- Currently completed: " + _amountCompleted + "/" + _target;
    }

    public override string GetStringRepresentation()
    {
        return 3 + "~" + base.GetStringRepresentation() + "~" + _target + "~" + _bonus + "~" + _amountCompleted + "~" + IsComplete();
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public  void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}