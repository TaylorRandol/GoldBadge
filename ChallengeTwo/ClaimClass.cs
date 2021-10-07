using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo
{
    public class ClaimClass
    {
        public ClaimClass() { }

        public ClaimClass (double claimID, ClaimType claimsType, string description, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            ClaimsType = claimsType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            
        }
        public double ClaimID { get; set; }

        public ClaimType ClaimsType { get; set; }

        public string Description { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool IsValid
        {
            get
            {
                if ((DateOfClaim - DateOfIncident).TotalDays < 30)
                    return true;
                else
                    return false;
            }
        }
        public enum ClaimType
        {
            Car,
            Home,
            Theft
        }
    }
}
