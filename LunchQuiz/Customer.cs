using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Customer
    {
        public bool ReadyToPlaceOrder(Order order, Restaurant restaurant )
        {
            bool isReady = order.VerifyOrderComplete() && restaurant.ItemIsOnMenu(order.Dessert) && restaurant.ItemIsOnMenu(order.Drink) && restaurant.ItemIsOnMenu(order.Entree);

            return isReady;
        }

        public bool ReadyToPlaceOrder(Order order, FastFood fastfood)
        {
            bool isReady = order.VerifyOrderComplete() && fastfood.ItemIsOnMenu(order.Dessert) && fastfood.ItemIsOnMenu(order.Drink) && fastfood.ItemIsOnMenu(order.Entree);

            return isReady;
        }
    }
}
