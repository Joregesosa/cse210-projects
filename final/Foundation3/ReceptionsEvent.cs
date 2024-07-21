class ReceptionsEvent : Event
{

    private string _email;

    public ReceptionsEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public string GetFullDetails()
    {
        return $"Type: Reception\n{GetStandardDetails()}\nReservations: {_email}";
    }

}