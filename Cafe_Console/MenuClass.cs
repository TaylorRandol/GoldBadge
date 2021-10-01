﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Console
{
    public class MenuClass
    {
        public MenuClass() { }

        public MenuClass(int mealNumber, string mealName, string mealDescription, string mealIngredients, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public string MealDescription { get; set; }

        public string MealIngredients { get; set; }

        public decimal MealPrice { get; set; }
    }
}
