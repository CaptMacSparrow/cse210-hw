public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {

        _goals.Add(goal);
        Console.WriteLine($"Added goal: {goal._name}");
    }

    public void RecordEvent(string name)
    {
        foreach (Goal goal in _goals)
        {
            if (goal._name == name)
            {
                goal.RecordEvent();
                return;
            }
        }

        Console.WriteLine($"Goal not found: {name}");
    }

    public void DisplayGoals()
    {
        int totalPoints = 0;

        Console.WriteLine("Current Goals:");
        
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.IsComplete());
            totalPoints += goal._points;
        }

        Console.WriteLine($"Total Points: {totalPoints}");
    }

  
}