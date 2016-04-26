using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
    public class Restaurant
    {
       public List<MenuItem> MenuItems = new List<MenuItem>();

       public List<Customer> CurrentCustomers = new List<Customer>();

        public void AddCustomerToList(Customer customerObject)
        {
            CurrentCustomers.Add(customerObject);
        }

        public int Numberof4PersonTables { get; set; }
        public int Numberof2PersonTables { get; set; }

        public int capacity()
        {
            return Numberof4PersonTables * 4 + Numberof2PersonTables * 2;
        }
        

        public bool ItemIsOnMenu(string itemToCheck)
        {
            return MenuItems.Exists(MenuItem => MenuItem.Name == itemToCheck);
        }

        public bool ItemIsOnMenu(MenuItem newItem)
        {
            return MenuItems.Contains(newItem);
        }




        

    }
}
