using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Console
{
    public class MenuClass
    {
        public MenuClass() { }

        public MenuClass(string mealName, int mealNumber, string mealDescription, List<string> mealIngredients, decimal mealPrice)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public string MealDescription { get; set; }

        public List<string> MealIngredients { get; set; }

        public decimal MealPrice { get; set; }
    }
}
