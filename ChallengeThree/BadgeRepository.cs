using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree
{
    public class BadgeRepository
    {
        public Dictionary<double, List<string>> dict = new Dictionary<double, List<string>>();
        private List<BadgeClass> badges = new List<BadgeClass>();

        //Add Badge
        public bool AddBadge(BadgeClass newBadge)
        {
            int startingCount = badges.Count;

            badges.Add(newBadge);
            bool wasAdded = (badges.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //View Badges
        public List<BadgeClass> ViewBadges()
        {
            return badges;
        }
        //Get ID
        public BadgeClass GetBadgeID(double badgeNumber)
        {
            foreach(BadgeClass badge in badges)
            {
                if (badge.BadgeID == badgeNumber)
                    return badge;
                else
                    Console.WriteLine("Unfortunately, we could not find anyone with that Badge Number");
            }
            return null;
        }
        //Edit Badges
        public bool EditBadge(BadgeClass existing, BadgeClass updated)
        {
            if (existing != null)
            {
                existing.BadgeID = updated.BadgeID;
                existing.ListOfDoorNames = updated.ListOfDoorNames;
                return true;
            }
            else
                return false;
        }
    }
}
