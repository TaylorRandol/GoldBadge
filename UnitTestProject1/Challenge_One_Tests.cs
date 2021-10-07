using Cafe_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class Challenge_One_Tests
    {
        MenuClass menu = new MenuClass();
        [TestMethod]
        public void SetMealName()
        {
            MenuClass menu = new MenuClass();
            menu.MealName = "The BiG FooD Meal";

            string expected = "The BiG FooD Meal";
            string actual = menu.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMenuNumber()
        {
            menu.MealNumber = 15;

            int expected = 15;
            int actual = menu.MealNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetDescription()
        {
            menu.MealDescription = "Super amazing food! I promise you will love eating it! Best Stuff in the GALAXY";

            string expected = "Super amazing food! I promise you will love eating it! Best Stuff in the GALAXY";
            string actual = menu.MealDescription;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealPrice()
        {
            menu.MealPrice = 9.35m;

            decimal expected = 9.35m;
            decimal actual = menu.MealPrice;

            Assert.AreEqual(expected, actual);
        }
    }
}
