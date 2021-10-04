using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo
{
    public class ClaimRepository
    {
        public readonly List<ClaimClass> _claims = new List<ClaimClass>();
        //Create new claim data
        public bool AddToClaim()
        {
            Queue claimsQueue = new Queue();
            claimsQueue.Enqueue(_claims);
            return;
            
        }
        public bool AddToClaims(ClaimClass claim)
        {
            int startingCount = _claims.Count;

            _claims.Add(claim);

            bool wasAdded = (_claims.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Show claims listed out in queue order
        public List<ClaimClass> GetClaimClasses()
        {
            return _claims;
        }

        //Show next claim to be handled in the queue
        
    }
}
