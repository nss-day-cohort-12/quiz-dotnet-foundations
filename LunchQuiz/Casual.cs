using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Casual: Restaurant
    {
        public bool HasPatio { get; set; }

        //Constructor CTOR
        public Casual()
        {
            MenuItems.Add(new MenuItem() { Name = "hamburger", Description = "delicious", Price = 5.25 });

        }
    }
}
