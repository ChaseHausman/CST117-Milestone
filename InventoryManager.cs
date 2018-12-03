using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    class InventoryManager
    {
        private Item[] Items;

        public InventoryManager()
        {
            this.Items = new Item[0];
        }

        public void Add(Item newItem)
        {
            Item[] temp = new Item[this.Items.Length + 1];

            int id = 0;
            foreach(Item item in this.Items)
            {
                temp[id] = this.Items[id];
                id++;
            }

            temp[id] = newItem;

            this.Items = temp;
        }

        public void Remove(Item RemovedItem)
        {
            Item[] temp = new Item[this.Items.Length - 1];
            int id = 0;
            foreach(Item item in this.Items)
            {
                if(item.GetId() != RemovedItem.GetId())
                {
                    temp[id] = item;
                }

                id++;
            }

            this.Items = temp;
        }

        public int Restock(Item Item, int Quantity)
        {
            for(int i = 0; i < this.Items.Length; i++)
            {
                if(this.Items[i].GetId() == Item.GetId())
                {
                    return this.Items[i].RecieveInventory(Quantity);
                }
            }

            return 0;
        }

        public Item[] Display()
        {
            foreach(Item i in this.Items)
            {
                Console.WriteLine(i.GetDescription() + ": $" + i.GetPrice()+" ("+i.GetStock()+" available)");
            }

            return this.Items;
        }

        public Item[] Search(String name)
        {
            List<Item> temp = new List<Item>();

            foreach(Item i in this.Items)
            {
                if(i.GetDescription().Contains(name))
                {
                    temp.Add(i);
                }
            }

            return temp.ToArray();
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
    }
}
