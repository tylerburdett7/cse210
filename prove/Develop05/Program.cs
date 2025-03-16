using System;
using System.Xml.Serialization;

class Program
{

    
    static void Main(string[] args)
    {
        bool done = false;
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        while(!done) {
            Console.WriteLine($"You have {totalPoints} points\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load goals\n5. Record Event\n6. Quit\n");
            Console.Write("Select an option from the menu: ");
            string choice = Console.ReadLine();
            
            if(choice == "1") {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
                Console.WriteLine("Select a goal type: ");
                string typeChoice = Console.ReadLine();

                Console.WriteLine("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.WriteLine("Write a description for your goal: ");
                string goalDescription = Console.ReadLine();

                Console.WriteLine("How many points do you want associated with this goal? ");
                string points = Console.ReadLine();
                int goalPoints = int.Parse(points);
                

                if(typeChoice == "1") {
                    var simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false);
                    goals.Add(simpleGoal);
                }
                else if(typeChoice == "2") {
                    var eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                    goals.Add(eternalGoal);
                }
                else if(typeChoice == "3") {
                    Console.WriteLine("how many times do you want to complete this goal for a bonus? ");
                    string total = Console.ReadLine();
                    int totalToComplete = int.Parse(total);
                    Console.WriteLine("How many bonus points for completing the goal that many times? ");
                    string userBonus = Console.ReadLine();
                    int bonusPoints = int.Parse(userBonus);

                    var checkListGoal = new CheckListGoal(goalName, goalDescription, goalPoints, bonusPoints, totalToComplete, 0);

                    goals.Add(checkListGoal);
                }

            }
            else if(choice == "2") {
                Console.WriteLine("\nThe goals are:");
                foreach(Goal goal in goals) {
                    goal.Display();
                }
            }
            else if(choice == "3") {
                File.Delete("goals.txt");

                using (StreamWriter outputFile = new StreamWriter("goals.txt")) {
                    outputFile.WriteLine(totalPoints);
                }

                foreach(Goal goal in goals) {
                    goal.SaveGoal("goals.txt");
                }
            }
            else if(choice == "4") {

                string filename = "goals.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                totalPoints = int.Parse(lines[0]);
                
                for (int i = 1; i < lines.Count(); i++) {
                   var elements = lines[i].Split("`");

                   Goal goal = null;
                   if (elements[0] == "SimpleGoal") {
                    goal = new SimpleGoal(elements);
                   }
                   else if (elements[0] == "EternalGoal") {
                    goal = new EternalGoal(elements);
                   }
                   else if (elements[0] == "CheckListGoal") {
                    goal = new CheckListGoal(elements);
                   }

                   if (goal != null) {
                    goals.Add(goal);
                   }
                }

            }
            else if(choice == "5") {
                Console.WriteLine("The goals are: ");

                int goalNumber = 1;
                foreach(Goal goal in goals) {

                    Console.Write(goalNumber + ". ");
                    goal.DisplayName();
                    goalNumber++;
                }
                string userChoice = Console.ReadLine();
                var selectedGoal = goals[int.Parse(userChoice) - 1];
                int pointsEarned = selectedGoal.SetCompleted();
                totalPoints += pointsEarned;
                Console.WriteLine($"Good work! you earned {pointsEarned} points");

            }
            else if(choice == "6") {
                done = true;
            }
        }

    }
}