using System;
using System.IO;

public class Program
{
    static List<Goal> goals = new List<Goal>();
    
    
    static void Main(string[] args)
    {
        int _totalPoints = 0;

        string tempFile = "goalsFile.txt";
        using (StreamWriter outputFile = new StreamWriter(tempFile, append: true))
            {
                outputFile.WriteLine("0");
            }
        Console.WriteLine("Welcome to your Goal Tracker!");

        while (true)
        {
            //menu
            Console.WriteLine(" ");
            Console.WriteLine($"Total Points: {_totalPoints}");
            Console.WriteLine(" ");
            Console.WriteLine("Please select one of the following options:");
             Console.WriteLine(" ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Display Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            //receive input
            string _selection = Console.ReadLine();
            //error message if input isn't 1-5
            while (_selection != "1" && _selection != "2" && _selection != "3" && _selection != "4" && _selection != "5" && _selection != "6")
            {
                Console.WriteLine("Invalid response.  Please choose a number between 1 and 5.");
                _selection = Console.ReadLine();
            } 

            string name = "";
            string description = "";
            int points = 0;
            int totalPoints = 0;
            string strPoints = "";
            int bonusPoints = 0;
            string strBonusPoints = "";
            int interval = 0;
            string strInterval = "";
            int targetCount = 0;
            string strTargetCount = "";
            string goalFile = "";
            string _strTotalPoints = "";

            switch (_selection)
            {
                case "1":
                    //goal = new SimpleGoal(name, description, points, bonusPoints);
                    Console.WriteLine("Please choose the type of goal you would like to create (enter 1 for a Simple Goal, 2 for an Eternal Goal, or 3 for a Checklist Goal):  ");
                    string goalType = Console.ReadLine();                    
                    //Console.WriteLine(lines[0]);
                    if (goalType == "1")
                    {
                        SimpleGoal sg = new SimpleGoal(name, description, points, totalPoints, strPoints);
                        name = sg.GetName();
                        description = sg.GetDescription();
                        points = sg.GetPoints();
                        goals.Add(sg);
                        
                        using (StreamWriter outputFile = new StreamWriter(tempFile, append: true))
                        {
                            outputFile.WriteLine("SimpleGoal" + "|" + sg._name + "|" + sg._description + "|" + sg._points + "|" + "0" + "|" + "0" + "|" + "0" + "|" + " ");
                        } 
                    }                    
                    
                    else if (goalType == "2")
                    {
                        EternalGoal eg = new EternalGoal(name, description, points, totalPoints, strPoints, interval, strInterval);
                        name = eg.GetName();
                        description = eg.GetDescription();
                        points = eg.GetPoints();
                        goals.Add(eg);

                        using (StreamWriter outputFile = new StreamWriter(tempFile, append: true))
                        {
                            outputFile.WriteLine("EternalGoal" + "|" + eg._name + "|" + eg._description + "|" + eg._points + "|" + "0" + "|" + "0" + "|" + "0" + "|" + " ");
                        } 
                    }

                    else if (goalType == "3")
                    {
                        ChecklistGoal cg = new ChecklistGoal(name, description, points, totalPoints, bonusPoints, strPoints, targetCount, strTargetCount, strBonusPoints, interval, strInterval);
                        name = cg.GetName();
                        description = cg.GetDescription();
                        points = cg.GetPoints();
                        targetCount = cg.GetTargetCount();
                        bonusPoints = cg.GetBonusPoints();
                        goals.Add(cg);
                       
                        using (StreamWriter outputFile = new StreamWriter(tempFile, append: true))
                        {
                            outputFile.WriteLine("ChecklistGoal" + "|" + cg._name + "|" + cg._description + "|" + cg._points + "|" + cg._bonusPoints + "|" + cg._targetCount + "|" + cg._interval + "|" + " ");
                        }
                    }
                    break;

                case "2":   //display goals
                    //if (goals.Count == 0)
                    //{
                    //    Console.WriteLine("No goals found.  You should add some! ");
                        //return;
                    //}

                    //else
                    //{
                    string[] lines = System.IO.File.ReadAllLines(tempFile);

                    var lineCount = File.ReadLines(tempFile).Count();
                    var counter = 0;
                
                    Console.WriteLine(" ");
                    Console.WriteLine("The goals are: ");
                    
                    foreach (string line in lines)
                    {
                        if (counter != 0)
                        {
                            string[] parts = line.Split("|");
                            string type = parts[0];
                            string _name = parts[1];
                            string _description = parts[2];
                            string _strPoints = parts[3];
                            string _strBonusPoints = parts[4];
                            string _strTargetCount = parts[5];
                            string _strInterval = parts[6];
                            string _isCompleted = parts[7];
                            //shows goals
                            if (type == "ChecklistGoal")
                            {
                                Console.WriteLine(counter + $". [{_isCompleted}] " + _name + " (" + _description + $") -- Currently completed:  {_strInterval}/{_strTargetCount}");
                            }
                            else
                            {
                                Console.WriteLine(counter + $". [{_isCompleted}] " + _name + " (" + _description + ")");
                            }
                        }
                        counter++;
                    }
                    break;
                
                case "3":   //save goals to file
                    Console.WriteLine("What is the filename for your goal file? ");
                    goalFile = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(goalFile))
                    {
                        string[] saveLines = System.IO.File.ReadAllLines(tempFile);

                        var saveLineCount = File.ReadLines(tempFile).Count();
                        var saveCounter = 0;

                        while (saveCounter < saveLineCount)
                        {
                            writer.WriteLine(saveLines[saveCounter]);
                            saveCounter++;
                        }
                    }

                    break;

                case "4":   //load goals from file
                    Console.WriteLine("What is the name of the file you would like to load? ");
                    string loadGoalFile = Console.ReadLine();

                    using (StreamWriter writer = new StreamWriter(tempFile))
                    {    
                        string[] loadLines = System.IO.File.ReadAllLines(loadGoalFile);
                        var loadLineCount = File.ReadLines(loadGoalFile).Count();
                        var loadCounter = 0;

                        while (loadCounter < loadLineCount)
                        {
                            writer.WriteLine(loadLines[loadCounter]);
                            
    
                            if (loadCounter == 0)
                            {
                                _strTotalPoints = loadLines[0];
                                _totalPoints = Convert.ToInt32(_strTotalPoints);
                            }
                            loadCounter++;
                        }
                    }

                    break;

                case "5":   //record event
                    string[] lines1 = System.IO.File.ReadAllLines(tempFile);

                    var lineCount1 = File.ReadLines(tempFile).Count();
                    var counter1 = 0;
                    Console.WriteLine("");
                    Console.WriteLine("The goals are: ");

                    foreach (string line in lines1)
                    {
                        counter1++;
                        if (counter1 > 1)
                        {
                            string[] parts = line.Split("|");
                            string type = parts[0];
                            string _name = parts[1];
                            string _description = parts[2];
                            string _strPoints = parts[3];
                            string _strBonusPoints = parts[4];
                            string _strTargetCount = parts[5];
                            string _strInterval = parts[6];
                            //shows goals
                            Console.WriteLine(counter1 -1 + ". " + _name + " (" + _description + ")");
                        }
                    }

                    Console.WriteLine(" ");                    
                    Console.WriteLine("Which goal did you accomplish? Enter the appropriate number.  ");
                    string _strRecordNumber = Console.ReadLine();
                    int _recordNumber = Convert.ToInt32(_strRecordNumber);
                    string[] parts1 = lines1[_recordNumber].Split("|");
                    string type1 = parts1[0];
                    string _name1 = parts1[1];
                    string _description1 = parts1[2];
                    string _strPoints1 = parts1[3];
                    int _points1 = Convert.ToInt32(_strPoints1);
                    string _strBonusPoints1 = parts1[4];
                    int _bonusPoints1 = Convert.ToInt32(_strBonusPoints1);
                    string _strTargetCount1 = parts1[5];
                    int _targetCount1 = Convert.ToInt32(_strTargetCount1);
                    string _strInterval1 = parts1[6];
                    int _interval1 = Convert.ToInt32(_strInterval1);
                    string _isCompleted1 = parts1[7];

                    switch (type1)
                    {
                        case "SimpleGoal":
                            SimpleGoal sg = new SimpleGoal(_name1, _description1, _points1, totalPoints, _strPoints1);
                            sg.RecordEvent();
                            _totalPoints += _points1;
                            _strTotalPoints = Convert.ToString(_totalPoints); 
                            lineChanger(_strTotalPoints, tempFile, 1);
                        break;

                        case "EternalGoal":
                            EternalGoal eg = new EternalGoal(_name1, _description1, _points1, totalPoints, _strPoints1, _interval1, _strInterval1);
                            eg.RecordEvent();
                            _totalPoints += _points1;
                            _strTotalPoints = Convert.ToString(_totalPoints); 
                            lineChanger(_strTotalPoints, tempFile, 1);
                        break;

                        case "ChecklistGoal":
                            ChecklistGoal cg = new ChecklistGoal(_name1, _description1, _points1, totalPoints, _bonusPoints1, _strPoints1, _targetCount1, _strTargetCount1, _strBonusPoints1, _interval1, _strInterval1);
                            cg.RecordEvent();
                            _totalPoints += _points1;
                            _strTotalPoints = Convert.ToString(_totalPoints); 
                            lineChanger(_strTotalPoints, tempFile, 1);
                        break;
                    }

                    if (type1 == "SimpleGoal")
                    { 
                        lineChanger(type1 + "|" + _name1 + "|" + _description1 + "|" + _strPoints1 + "|" + _strBonusPoints1 + "|" + _strTargetCount1 + "|" + _strInterval1 + "|" + "x", tempFile, _recordNumber + 1);
                    }
                    if (type1 == "ChecklistGoal")
                    {
                        _interval1++;
                        _strInterval1 = Convert.ToString(_interval1);
                        if (_interval1 == _targetCount1)
                        {
                            _totalPoints += _bonusPoints1;
                            _strTotalPoints = Convert.ToString(_totalPoints);
                            lineChanger(type1 + "|" + _name1 + "|" + _description1 + "|" + _strPoints1 + "|" + _strBonusPoints1 + "|" + _strTargetCount1 + "|" + _strInterval1 + "|" + "x", tempFile, _recordNumber + 1);
                            Console.WriteLine($"Completed!");
                        }
                        else
                        {
                            lineChanger(type1 + "|" + _name1 + "|" + _description1 + "|" + _strPoints1 + "|" + _strBonusPoints1 + "|" + _strTargetCount1 + "|" + _strInterval1 + "|" + " ", tempFile, _recordNumber + 1);
                        }
                    }
                    

                    break;
                
                case "6":
                    File.WriteAllText(tempFile, String.Empty);
                    Console.WriteLine("Come back soon! ");
                    
                    return;
            }
        }
        
        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}