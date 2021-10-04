using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Console
{
    public class ProgramUI
    {
        private MenuRepository _menuRepo = new MenuRepository();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of your selction:\n" +
                    "1. Add to menu list\n" +
                    "2. Delete from menu list\n" +
                    "3. See all menu items\n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "1":
                        //Add to menu list
                        NewMenuItem();
                        break;
                    case "2":
                        //Delete from menu list
                        break;
                    case "3":
                        //See all menu items
                        ShowMenu();
                        break;
                    case "4":
                        //Exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection from 1 - 4.");
                        WriteRead();
                        break;
                }
            }
        }

        //Create New Menu Items
        private void NewMenuItem()
        {
            Console.Clear();

            MenuClass menuClass = new MenuClass();
            List<string> list = new List<string>();

            Console.WriteLine("Enter the Name of the new item:");
            menuClass.MealName = Console.ReadLine();

            Console.WriteLine("Enter the Number of the new item:");
            menuClass.MealNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Description of the new item:");
            menuClass.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter the list of Ingredients:");
            string ingredients = Console.ReadLine();
            list.Add(ingredients);

            while (ingredients != "")
            {
                Console.WriteLine("next ingredient:");
                ingredients = Console.ReadLine();
                list.Add(ingredients);
            }
            if (ingredients == "")
            {
                foreach (string input in list)
                {
                    Console.WriteLine($"{input} added to ingredients list.");
                }
                Console.ReadLine();
            }

            Console.WriteLine("Enter the price:");
            menuClass.MealPrice = Convert.ToDecimal(Console.ReadLine());

            list = menuClass.MealIngredients();
            _menuRepo.AddToMenu(menuClass);
        }

        private void ShowMenu()
        {
            Console.Clear();
            List<MenuClass> menuList = _menuRepo.GetMenuItems();

            foreach (MenuClass item in menuList)
            {
                DisplayMenu(item);
            }
            WriteRead();
        }

        //Helper Methods
        private void WriteRead()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void DisplayMenu(MenuClass menuClass)
        {
            Console.WriteLine($"Name: {menuClass.MealName}\n" +
                $"Menu number: #{menuClass.MealNumber}\n" +
                $"Description: {menuClass.MealDescription}\n" +
                $"Ingredients: {menuClass.MealIngredients}\n" +
                $"Price: ${menuClass.MealPrice}");
        }
    }
}
