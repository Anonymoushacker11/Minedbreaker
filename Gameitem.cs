using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
   public class GameItem
   {
      public int ItemTypeID { get; set; }
      public string Name { get; set; }
      public int Price { get; set; }
      
      public Gameitem(int itemTypeID, string name, int price)
      {
          ItemTypeID = itemTypeID;
          Name = name;
          Price = price;
      }
   }
}
