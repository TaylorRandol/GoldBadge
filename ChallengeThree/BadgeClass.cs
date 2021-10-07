using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    public class BadgeClass
    {
        public double BadgeID { get; set; }

        public List<string> ListOfDoorNames { get; set; }

        public BadgeClass() { }
        public BadgeClass(double badgeID, List<string> listOfDoorNames)
        {
            BadgeID = badgeID;
            ListOfDoorNames = listOfDoorNames;
        }
    }
}
