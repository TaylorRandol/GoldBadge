using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    public class ProgramUI
    {
        readonly BadgeRepository _repo = new BadgeRepository();
        Dictionary<double, List<string>> dict = new Dictionary<double, List<string>>();
        public void Run()
        {
            SeedData();

            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Hello Security Admin, What would you like to do?\n\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n" +
                    "4. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //add a badge
                        AddNewBadge();
                        break;
                    case "2":
                        //edit a badge
                        EditBadge();
                        break;
                    case "3":
                        //List all badges
                        ListAllBadges();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input between 1 and 4.");
                        WriteRead();
                        break;
                }
            }

        }

        private void AddNewBadge()
        {
            Console.Clear();
            Console.WriteLine("What is the Badge ID Number: ");
            double badgeNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("List a door that ID needs access to: ");
            List<string> doorAccess = new List<string> { Console.ReadLine() };
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.WriteLine("Add another door(y/n)?");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();
                if (userInput == "y")
                {
                    Console.WriteLine("List a door that ID needs access to: ");
                    doorAccess.Add(Console.ReadLine());
                }
                else
                    isRunning = false;
            }
            dict.Add(badgeNumber, doorAccess);
            BadgeClass content = new BadgeClass(badgeNumber, doorAccess);
            _repo.AddBadge(content);
        }

        private void EditBadge()
        {
            Console.Clear();
            Console.WriteLine("What BadgeId Number would you like to update?");
            double input = double.Parse(Console.ReadLine());
            BadgeClass badge = _repo.GetBadgeID(input);

            Console.WriteLine($"{badge.BadgeID} has access to these doors {badge.ListOfDoorNames}");
            Console.WriteLine("What would you like to do?\n" +
                "1. Remove a door\n" +
                "2. Add a new door\n");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Which door would you like to remove?");
                    string user1 = Console.ReadLine();
                    badge.ListOfDoorNames.Remove(user1);
                    Console.WriteLine($"{badge.BadgeID} now has access to these doors {badge.ListOfDoorNames}");
                    break;
                case "2":
                    Console.WriteLine("Which dooe would you like to add?");
                    string user2 = Console.ReadLine();
                    badge.ListOfDoorNames.Add(user2);
                    Console.WriteLine($"{badge.BadgeID} now has access to these doors {badge.ListOfDoorNames}");
                    break;
                default:
                    Console.WriteLine("Incorrect input please try again.");
                    EditBadge();
                    break;
            }
        }

        private void ListAllBadges()
        {
            Console.Clear();
            Console.WriteLine("Key");
            Console.WriteLine(new String('_', 50));
            Console.WriteLine("BadgeID#\tDoorAccess");
            Console.WriteLine(new String('-', 50));
            foreach (var id in dict)
            {
                Console.WriteLine($"{id.Key}");
                foreach (var door in id.Value)
                    Console.WriteLine($"\t\t{door} ");
            }
            Console.WriteLine("\n");
            WriteRead();
        }

        //Helper methods
        private void WriteRead()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void SeedData()
        {
            BadgeClass person1 = new BadgeClass(123456d, new List<string>() { "A1", "A2", "B3" });
            BadgeClass person2 = new BadgeClass(298675d, new List<string>() { "C4", "D5", "E6" });
            _repo.AddBadge(person1);
            _repo.AddBadge(person2);
            dict.Add(person1.BadgeID, person1.ListOfDoorNames);
            dict.Add(person2.BadgeID, person2.ListOfDoorNames);
        }
    }
}
