using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    class ItemTests
    {
        public static void Main()
        {
            Console.WriteLine("## Creating new item ##");
            Item TestItem = new Item(1, "Solomon Bent Chettler 100", 200.00, 499.99, 12, "176mm", "", "Skis");

            Console.WriteLine("   ID: " + TestItem.GetId());
            Console.WriteLine(" Desc: " + TestItem.GetDescription());
            Console.WriteLine("Price: " + TestItem.GetPrice());
            Console.WriteLine(" Cost: " + TestItem.GetCost());
            Console.WriteLine("Stock: " + TestItem.GetStock());
            Console.WriteLine(" Size: " + TestItem.GetSizing());
            Console.WriteLine("Color: " + TestItem.GetColor());
            Console.WriteLine("  Cat: " + TestItem.GetCategory());

            Console.WriteLine();
            Console.WriteLine("## Updating Item ##");

            TestItem.SetDescription("Atomic Shift");
            TestItem.SetPrice(549.99);
            TestItem.SetCost(376.95);
            TestItem.SetStock(3);
            TestItem.SetSizing("");
            TestItem.SetColor("Blue/Black");
            TestItem.SetCategory("Bindings");

            Console.WriteLine("   ID: " + TestItem.GetId());
            Console.WriteLine(" Desc: " + TestItem.GetDescription());
            Console.WriteLine("Price: " + TestItem.GetPrice());
            Console.WriteLine(" Cost: " + TestItem.GetCost());
            Console.WriteLine("Stock: " + TestItem.GetStock());
            Console.WriteLine(" Size: " + TestItem.GetSizing());
            Console.WriteLine("Color: " + TestItem.GetColor());
            Console.WriteLine("  Cat: " + TestItem.GetCategory());

            Console.WriteLine();
            Console.WriteLine("## Selling 1 Item ##");

            Console.WriteLine("Available: " + TestItem.GetStock());
            TestItem.Sell();
            Console.WriteLine("Available: " + TestItem.GetStock());

            Console.WriteLine();
            Console.WriteLine("## Selling 2 Items ##");

            Console.WriteLine("Available: " + TestItem.GetStock());
            TestItem.Sell(2);
            Console.WriteLine("Available: " + TestItem.GetStock());

            Console.WriteLine();
            Console.WriteLine("## Selling Item Without Stock ##");

            Console.WriteLine("Available: " + TestItem.GetStock());
            TestItem.Sell();
            Console.WriteLine("Available: " + TestItem.GetStock());

            Console.WriteLine();
            Console.WriteLine("## Recieving New Inventory (6 Items) ##");

            Console.WriteLine("Available: " + TestItem.GetStock());
            TestItem.RecieveInventory(6);
            Console.WriteLine("Available: " + TestItem.GetStock());

            Console.WriteLine();
            Console.WriteLine("## Getting Profit Margin ($137.04) ##");

            Console.WriteLine("Margin: " + TestItem.GetMargin());

            Console.WriteLine();
            Console.WriteLine("## Setting Profit Margin of $150.50 ##");

            Console.WriteLine("New Price: " + TestItem.SetMargin(150.50));
            Console.WriteLine("New Margin: " + TestItem.GetMargin());
            Console.WriteLine("Stored Price: " + TestItem.GetPrice());
        }
    }
}
