using System;

class BreathingActivity : Activity
{
    protected override void RunActivity()
    {
        for (int i = 0; i < _duration; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in... ");
            }
            else
            {
                Console.WriteLine("Breathe out... ");
            }
            Pause(3);
        }
    }
    //private string _inhale; //= "Breathe in...";
    //private string _exhale; //= "Breathe out...";

    //public BreathingActivity(string name, string description, int duration, string inhale, string exhale)
    //    : base(name, description, duration)
    //{
    //    _inhale = inhale;
    //    _exhale = exhale;
    //}
    
    //public string GetInhale()
    //{
    //    return _inhale;
    //}
    //public void SetInhale(string inhale)
    //{
    //    _inhale = inhale;
    //}

    //public string GetExhale()
    //{
    //    return _exhale;
    //}
    //public void SetExhale(string exhale)
    //{
    //    _exhale = exhale;
    //}    
}