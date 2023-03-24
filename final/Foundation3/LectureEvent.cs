public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string type, string title, string description, string date, string time, string address, string speaker, int capacity) 
        : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLectureFullDetails()
    {
        string type = GetType();
        string lectureFullDetails = GetStandardDetails() + $"\nType: {type} \nSpeaker: {_speaker} \nCapacity: {_capacity}";
        return lectureFullDetails;
    }
}