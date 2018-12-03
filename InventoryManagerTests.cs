using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    class InventoryManagerTests
    {
        public static void Main()
        {
            Console.WriteLine("Creating a new inventory manager and adding new items.");

            InventoryManager manager = new InventoryManager();
            Item testItem1 = new Item(1,"Stuff",10.51,16,10,"Large",null,"Stuffs");
            Item testItem2 = new Item(2,"Things", 15.10,22.2,11,"Small",null,"Stuffs");
            Item testItem3 = new Item(3, "Dohickies", 7.25, 11.5, 1, "Small", null, "Stuffs");
            manager.Add(testItem1);
            manager.Add(testItem2);
            manager.Add(testItem3);

            Console.WriteLine("Displaying Items.");
            manager.Display();

            Console.WriteLine("Removing an item.");
            manager.Remove(testItem3);
            manager.Display();

            Console.WriteLine("Restocking an item.");
            manager.Restock(testItem2, 10);
            manager.Display();
        }
    }
}
