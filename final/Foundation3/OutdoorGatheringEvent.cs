class OutdoorGatheringEvent : Event
{

    private string _weatherForecast;

    public OutdoorGatheringEvent(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"Type: Outdoor Gathering\nWeather: {_weatherForecast}\n{GetStandardDetails()}";
    }
    
}