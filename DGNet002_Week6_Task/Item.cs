using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGNet002_Week6_Task
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }

        public static List<Item> items = new List<Item>()
        {
            new Item {ItemId = 1, ItemDescription = "Bag"},
            new Item {ItemId = 2, ItemDescription = "Pen"},
            new Item {ItemId = 3, ItemDescription = "Bag"},
            new Item {ItemId = 4, ItemDescription = "Shoe"},
            new Item {ItemId = 5, ItemDescription = "Pin"},
        };
                      

    }
}
