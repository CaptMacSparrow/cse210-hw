public class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string type, string title, string description, string date, string time, string address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string Type=> _type;
    public string Title=> _title;
    public string GetType()
    {
        return _type;
    }
    
    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address;
    }

    public string GetStandardDetails()
    {
        string standardDetails = $"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress:\n{_address}";
        return standardDetails; 
    }

    public string GetShortDescription()
    {
        string shortDescription = $"Type: {_type} \nTitle: {_title} \nDate: {_date}";
        return shortDescription;
    }
}