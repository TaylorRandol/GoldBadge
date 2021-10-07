using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    public class ProgramUI
    {
        public void Run()
        {
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

        }
        private void EditBadge()
        {

        }
        private void ListAllBadges()
        {

        }

        //Helper methods
        private void WriteRead()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
