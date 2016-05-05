using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
  public class FastFood : Restaurant, IProvidesDinner, IProvidesLunch
    {
    public bool HasDriveThrough { get; set; }


    public void addMenuItem(string String)
    {
      MenuItem item = new MenuItem(String);
      MenuItems.Add(item);
    }


    public void addMenuItem(string String, double Double)
    {
      MenuItem item = new MenuItem(String, Double);
      MenuItems.Add(item);
    }



  }
}
