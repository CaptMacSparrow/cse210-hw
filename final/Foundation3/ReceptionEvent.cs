public class ReceptionEvent : Event
{
    private string _rsvp;

    public ReceptionEvent(string type, string title, string description, string date, string time, string address, string rsvp)
        : base(type, title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public string GetReceptionFullDetails()
    {
        string type = GetType();
        string receptionFullDetails = GetStandardDetails() + $"\nType: {type} \nRSVP: {_rsvp}";
        return receptionFullDetails;
    }    
}