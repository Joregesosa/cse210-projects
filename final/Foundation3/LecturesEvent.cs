class LecturesEvent: Event
{
    private string _speaker;
    private int _capacity;

    public LecturesEvent(string title, string description, string date, string time, Address address, string speaker, int capacity): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Type: Lecture\n{_speaker}\n{_capacity}\n{GetStandardDetails()}";
    }



}