using LunchQuiz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class FastFood: Restaurant, IProvidesLunch
    {
        public bool HasDriveThrough { get; set; }

        public void addMenuItem(string foodName)
        {
            MenuItem menuitem = new MenuItem();
            menuitem.Name = foodName;
            MenuItems.Add(menuitem);
        }

        public void addMenuItem(string foodName, double foodPrice)
        {
            MenuItem menuitem = new MenuItem();
            menuitem.Name = foodName;
            menuitem.Price = foodPrice;
            MenuItems.Add(menuitem);
        }
    }
}
