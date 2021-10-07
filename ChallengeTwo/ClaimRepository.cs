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
        public Queue<ClaimClass> _claims = new Queue<ClaimClass>();
        //Create new claim data
        public void AddToClaim(ClaimClass claim)
        {
            _claims.Enqueue(claim);
        }
        
        //Show claims listed out in queue order
        public Queue<ClaimClass> GetClaimClasses()
        {
            return _claims;
        }
      
        public bool RemoveClaimFromQueue()
        {
            int startingCount = _claims.Count;
            _claims.Dequeue();

            if (startingCount > _claims.Count)
                return true;
            else
                return false;
        }
    }
}
