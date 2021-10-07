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
            SeedData();
            RunMenu();
        }

        private void RunMenu()
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
                        AllClaims();
                        break;
                    case "2":
                        //next claim in queue
                        NextClaim();
                        break;
                    case "3":
                        //enter a new claim
                        AddNewClaim();
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
            Queue<ClaimClass> queue = _repo.GetClaimClasses();

            Console.WriteLine(String.Format("{0,-5}|{1,-5}|{2,-20}|{3,-5}|{4,-5:d}|{5,-5:d}|{6,0}", "ClaimID", "Type", "Description", "Amount", "Date of Accident", "Date of Claim", "IsValid"));
            Console.WriteLine(new String('-', 80));
            foreach (var claim in queue)
            {
                DisplayClaims(claim);
            }
            WriteRead();
        }

        private void NextClaim()
        {
            Console.Clear();
            Queue<ClaimClass> queue = _repo.GetClaimClasses();

            Console.WriteLine(String.Format("{0,-5}|{1,-5}|{2,-20}|{3,-5}|{4,-5:d}|{5,-5:d}|{6,0}", "ClaimID", "Type", "Description", "Amount", "Date of Accident", "Date of Claim", "IsValid"));
            Console.WriteLine(new String('-', 80));
            Console.WriteLine(ShowClaim(queue.Peek()));
            WriteRead();
            DealWithClaim();
        }

        private void AddNewClaim()
        {
            Console.Clear();
            ClaimClass claim = new ClaimClass();

            Console.WriteLine("Enter the Claim ID:");
            claim.ClaimID = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Claim Type:");
            claim.ClaimType = Console.ReadLine();

            Console.WriteLine("Enter a Claim Description:");
            claim.Description = Console.ReadLine();

            Console.WriteLine("Amount of Damage:");
            claim.ClaimAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Date of Accident: ie:(mm/dd/yyyy)");
            claim.DateOfIncident = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Date of Claim: ie:(mm/dd/yyyy)");
            claim.DateOfClaim = Convert.ToDateTime(Console.ReadLine());

            _repo.AddToClaim(claim);

        }

        private void WriteRead()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void DisplayClaims(ClaimClass claim)
        {
            Console.WriteLine(String.Format("{0,-5}|{1,-5}|{2,-20}|{3,0:C}|{4,-15:d}|{5,-15:d}|{6,0}", claim.ClaimID, claim.ClaimType, claim.Description, claim.ClaimAmount, claim.DateOfIncident, claim.DateOfClaim, claim.IsValid));
        }
        
        private void SeedData()
        {
            var claim1 = new ClaimClass(1234567, "Car", "test words", 400.23m, new DateTime(2021, 5, 25), new DateTime(2021, 5, 27));
            var claim2 = new ClaimClass(2234678, "Home", "test tests", 122.43m, new DateTime(2021, 5, 18), new DateTime(2021, 6, 18));

            _repo.AddToClaim(claim1);
            _repo.AddToClaim(claim2);
        }

        public string ShowClaim(ClaimClass claim)
        {
            return String.Format("{0,-5}|{1,-5}|{2,-20}|{3,0:C}|{4,-15:d}|{5,-15:d}|{6,0}", claim.ClaimID, claim.ClaimType, claim.Description, claim.ClaimAmount, claim.DateOfIncident, claim.DateOfClaim, claim.IsValid);
        }

        public void DealWithClaim()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Do you want to deal with this claim now(y/n)?");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    _repo.RemoveClaimFromQueue();
                    Console.WriteLine("The claim has been removed from the queue.");
                    isRunning = false;
                }
                if (input == "n")
                {
                    isRunning = false;
                }
                else
                    Console.WriteLine("\nPlease enter a valid option");
            }
        }
    }
}
