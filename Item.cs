using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    class Item
    {
        private readonly int Id;
        private String Description;
        private double Cost;
        private double Price;
        private int Stock;
        private String Sizing;
        private String Color;
        private String Category;

        // Constructor for creating a new item.
        public Item(int id, string description, double cost, double price, int stock, string sizing, string color, string category)
        {
            this.Id = id;
            this.Description = description;
            this.Cost = cost;
            this.Price = price;
            this.Stock = stock;
            this.Sizing = sizing;
            this.Color = color;
            this.Category = category;
        }

        // Returns the item ID. Cannot be changed one created.
        public int GetId()
        {
            return this.Id;
        }

        // Returns the item description
        public String GetDescription()
        {
            return this.Description;
        }

        // Sets the item description
        public void SetDescription(String desc)
        {
            this.Description = desc;
        }

        // Returns the items cost
        public double GetCost()
        {
            return this.Cost;
        }

        // Sets the item cost
        public void SetCost(double cost)
        {
            this.Cost = cost;
        }

        // Returns the item price
        public double GetPrice()
        {
            return this.Price;
        }

        // Sets the item price
        public void SetPrice(double price)
        {
            this.Price = price;
        }

        // Returns the quantity of items available in stock to sell
        public int GetStock()
        {
            return this.Stock;
        }

        // Sets a new quantity of items available in stock
        public void SetStock(int stock)
        {
            this.Stock = stock;
        }

        // Returns the size (if applicable) of the item
        public string GetSizing()
        {
            return this.Sizing;
        }

        // Sets the size (if applicable)
        public void SetSizing(string sizing)
        {
            this.Sizing = sizing;
        }

        // Returns the item color (if applicable)
        public string GetColor()
        {
            return this.Color;
        }

        // Sets the item color (if applicable)
        public void SetColor(string color)
        {
            this.Color = color;
        }

        // Returns the item's category
        public string GetCategory()
        {
            return this.Category;
        }

        // Sets the item's category
        public void SetCategory(string category)
        {
            this.Category = category;
        }

        // Reduces stock by one, if there is available stock to sell. 
        // Returns TRUE on success or FALSE if not enough stock.
        public bool Sell()
        {
            if(this.GetStock() > 0)
            {
                this.SetStock(this.GetStock() - 1);
                return true;
            }

            return false;
        }

        // Same as Sell() but allows for a custom quantity
        public bool Sell(int quantity)
        {
            if (this.GetStock() - quantity > 0)
            {
                this.SetStock(this.GetStock() - quantity);
                return true;
            }

            return false;
        }

        // Increases the number of available inventory without
        // needing to do math manually
        public int RecieveInventory(int additionalQty)
        {
            this.SetStock(this.GetStock() + additionalQty);

            return this.GetStock();
        }

        // Returns the difference between the customer's price and the item's cost
        public double GetMargin()
        {
            return this.GetPrice() - this.GetCost();
        }

        // Adjusts the price of the item to achieve a specific margin
        // Returns the new price that was calculated.
        public double SetMargin(double goal)
        {
            this.SetPrice(this.GetCost() + goal);

            return this.GetPrice();
        }
    }
}
