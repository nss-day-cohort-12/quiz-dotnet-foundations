using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
  public class Customer
  {

    public bool ReadyToPlaceOrder(Order order, Restaurant restaurant)
    {
      if(order.VerifyOrderComplete())
      {
        if(restaurant.MenuItems.Exists(item => item.Name == order.Drink) 
          && restaurant.MenuItems.Exists(item => item.Name == order.Entree) 
          && restaurant.MenuItems.Exists(item => item.Name == order.Dessert))
          {
          return true;
          }
      }
        return false;
    }

  }
}
