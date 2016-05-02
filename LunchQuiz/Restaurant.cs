using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
  public class Restaurant
  {

    public int Numberof4PersonTables { get; set; }
    public int Numberof2PersonTables { get; set; }

    public List<MenuItem> MenuItems = new List<MenuItem>();
 
    public List<Customer> CurrentCustomers = new List<Customer>();

    public void AddCustomerToList(Customer customer)
    {
      CurrentCustomers.Add(customer);
    }

    public virtual int capacity()
    {
      return (Numberof2PersonTables * 2) + (Numberof4PersonTables * 4);
    }

    public bool ItemIsOnMenu(string String)
    {
     return MenuItems.Exists(x => x.Name == String);
    }
    // in this case, x is a placeholder, it represents the MenuItem itself in MenuItems

    public bool ItemIsOnMenu(MenuItem item)
    {
      return MenuItems.Exists(x => x == item);
    }
    // here, x = MenuItem, the object itself


  }
}
