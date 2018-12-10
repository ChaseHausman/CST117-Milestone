using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    class InventoryManager
    {
        private List<Item> Items;

        public InventoryManager()
        {
            this.Items = new List<Item>();
        }

        public void Add(Item newItem)
        {
            this.Items.Add(newItem);
        }

        public void Remove(Item RemovedItem)
        {
            this.Items.Remove(RemovedItem);
        }

        public int Restock(Item Item, int Quantity)
        {
            int index = this.Items.IndexOf(Item);

            if(index < 0)
            {
                return 0;
            }

            return this.Items[index].RecieveInventory(Quantity);
        }

        public List<Item> Display()
        {
            foreach(Item i in this.Items)
            {
                Console.WriteLine(i.GetDescription() + ": $" + i.GetPrice()+" ("+i.GetStock()+" available)");
            }

            return this.Items;
        }

        public List<Item> Search(String name)
        {
            List<Item> temp = new List<Item>();

            foreach(Item i in this.Items)
            {
                if(i.GetDescription().Contains(name))
                {
                    temp.Add(i);
                }
            }

            return temp;
        }

        public Item[] Search(Double price)
        {
            List<Item> temp = new List<Item>();

            foreach (Item i in this.Items)
            {
                if (i.GetPrice().Equals(price))
                {
                    temp.Add(i);
                }
            }

            return temp.ToArray();
        }

        public List<Item> GetItemsList()
        {
            return this.Items;
        }
    }
}
