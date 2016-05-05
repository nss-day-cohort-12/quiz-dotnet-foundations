using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchQuiz
{
  public class Casual : Restaurant, IProvidesDinner, IProvidesLunch
    {
    public bool HasPatio { get; set; }

    public Casual()
    {
      MenuItem edamame = new MenuItem();
      MenuItems.Add(edamame);
    }

  }
}
