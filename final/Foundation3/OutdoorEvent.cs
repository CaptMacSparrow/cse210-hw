public class OutdoorEvent : Event
{
    private string _forecast;

    public OutdoorEvent(string type, string title, string description, string date, string time, string address, string forecast)
        : base(type, title, description, date, time, address)
    {
        _forecast = forecast;
    }    

    public string GetOutdoorFullDetails()
    {
        string type = GetType();
        string outdoorFullDetails = GetStandardDetails() + $"\nType: {type} \nForecast: {_forecast}"; 
        return outdoorFullDetails;
    }
}