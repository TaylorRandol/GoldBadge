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

        }
        private void ListAllBadges()
        {
            Console.Clear();
            Console.WriteLine("Key");
            Console.WriteLine("BadgeID#\t\tDoorAccess");
            
            foreach(KeyValuePair<double, List<string>> key in dict)
            {
                Console.WriteLine($"{key.Key.ToString()}\t\t");
                foreach(string word in key.Value)
                    Console.WriteLine($"{word},");
                Console.WriteLine("\n");
            }
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
            BadgeClass person2 = new BadgeClass(098675d, new List<string>() { "C4", "D5", "E6" });
            _repo.AddBadge(person1);
            _repo.AddBadge(person2);
            dict.Add(person1.BadgeID, person1.ListOfDoorNames);
            dict.Add(person2.BadgeID, person2.ListOfDoorNames);
        }
    }
}
