using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo
{
    public class ProgramUI
    {
        private ClaimRepository _repo = new ClaimRepository();
        public void Run()
        {
            RunMenu();
        }

        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)

            {
                Console.Clear();
                Console.WriteLine("Choose a menu item:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //see all claims
                        break;
                    case "2":
                        //next claim in queue
                        break;
                    case "3":
                        //enter a new claim
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 4.");
                        WriteRead();
                        break;
                }
            }
        }

        private void AllClaims()
        {
            Console.Clear();
            List<ClaimClass> listOfClaims = _repo.GetClaimClasses();

        }

        private void WriteRead()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private void DisplayClaims(ClaimClass claim)
        {
            Console.WriteLine($"ClaimID");
        }
    }
}
