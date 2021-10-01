using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Console
{
    public class MenuRepository
    {
        public readonly List<MenuClass> _menuDirectory = new List<MenuClass>();
        //CRUD (no update at the moment)

        //Create menu items
        public bool AddToMenu(MenuClass menuItem)
        {
            int startingCount = _menuDirectory.Count;

            _menuDirectory.Add(menuItem);

            bool wasAdded = (_menuDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Show all menu items
        public List<MenuClass> GetMenuItems()
        {
            return _menuDirectory;
        }

        //Delete menu items
        public bool DeleteMenuItem(MenuClass currentMenuItem)
        {
            bool itemRemoved = _menuDirectory.Remove(currentMenuItem);
                return itemRemoved;
        }

    }
}
