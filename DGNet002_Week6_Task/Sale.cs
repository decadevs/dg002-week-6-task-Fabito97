using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGNet002_Week6_Task
{
    public class Sale
    {
        public int InvoiceNo { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        public static List<Sale> sales = new List<Sale>()
        {
            new Sale {InvoiceNo = 1, ItemId = 3, Quantity = 10},
            new Sale {InvoiceNo = 2, ItemId = 2, Quantity = 20},
            new Sale {InvoiceNo = 3, ItemId = 3, Quantity = 500},
            new Sale {InvoiceNo = 4, ItemId = 4, Quantity = 20},
            new Sale {InvoiceNo = 5, ItemId = 3, Quantity = 100},
            new Sale {InvoiceNo = 6, ItemId = 1, Quantity = 50},
        
        };
    }

}
