using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGNet002_Week6_Task
{
    public class Inventory
    {       
        public static void CreateNewInventory()
        {       
            var inventories = Item.items.Join(Sale.sales, 
                item => item.ItemId, 
                sale => sale.ItemId, 
                (item, sale) => new
            {
                item.ItemId,
                ItemName = item.ItemDescription,
                sale.Quantity,
            });

            Console.WriteLine("\nItemId \t ItemName     Quantity");
            Console.WriteLine("-------------------------------");

            foreach (var newItem in inventories)
            {
                Console.WriteLine($"  {newItem.ItemId}    \t   {newItem.ItemName}      \t{newItem.Quantity}");
            }
        }
    } 

}
