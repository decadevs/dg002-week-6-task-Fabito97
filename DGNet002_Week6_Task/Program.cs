namespace DGNet002_Week6_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Grouping of list of state in three sets.

             List<List<string>> groupedStates = State.GroupStatesInThree();

            Console.WriteLine("\nA Group of states in set of 3:\n");
            Console.WriteLine("--------------------------------");
            foreach (var group in groupedStates)
            {
                Console.WriteLine($"\n{string.Join(", ", group)}");
                Console.WriteLine("\n------------------------------");
            }


            // Grouping of list according to their first character

            ILookup<char, string> groupedStatesByFirstChar = State.GroupByFirstCharacter(State.states);

            foreach (var group in groupedStatesByFirstChar)
            {
                Console.WriteLine($"\nGroup {group.Key} - {group.Count()}:");
                Console.WriteLine("\n\t------------");

                Console.WriteLine($"\n\t{string.Join(", ", group)}");
            }



            // Creation of new inventories 

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
