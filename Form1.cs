using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class Form1 : Form
    {
        private InventoryManager Items = new InventoryManager();
        BindingList<Item> data;

        public Form1()
        {
            InitializeComponent();

            data = new BindingList<Item>(this.Items.GetItemsList());

            this.Items.Add(new Item(
                    0,
                    "Test Item",
                    10.56,
                    19.95,
                    10,
                    "Large",
                    "Green",
                    "Test"));

            UpdateDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetListToAllItems();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetListToAllItems();
        }

        private void SetListToAllItems()
        {
            ItemList.DataSource = null;

            ItemList.DataSource = data;
            ItemList.DisplayMember = "ListLine";

            this.Items.Display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemForm form = new ItemForm();

            if(form.ShowDialog(this) == DialogResult.OK)
            {
                Console.WriteLine("Creating new Item to Store");

                this.Items.Add(new Item(
                    0,
                    form.DescriptionBox.Text,
                    Convert.ToDouble(form.CostBox.Text),
                    Convert.ToDouble(form.PriceBox.Text),
                    Convert.ToInt16(form.StockBox.Text),
                    form.SizeBox.Text,
                    form.ColorBox.Text,
                    form.CategoryBox.Text));

                SetListToAllItems();
            }
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            String query = SearchBox.Text;

            ItemList.DataSource = this.Items.Search(query);
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            Item selected = (Item) ItemList.SelectedItem;
            
            if(selected != null)
            {
                SelectedDescription.Text = selected.GetDescription();
                SelectedPrice.Text = selected.GetPrice().ToString();
                SelectedCost.Text = selected.GetCost().ToString();
                SelectedInventory.Text = selected.GetStock().ToString();
            }
        }

        private void RefreshList()
        {
            Object tempSource = ItemList.DataSource;
            String tempDisplay = ItemList.DisplayMember;

            ItemList.DataSource = null;
            ItemList.DisplayMember = null;

            ItemList.DataSource = tempSource;
            ItemList.DisplayMember = tempDisplay;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            Item selected = (Item)ItemList.SelectedItem;

            this.Items.Remove(selected);

            RefreshList();
        }

        private void RestockButton_Click(object sender, EventArgs e)
        {
            Item selected = (Item) ItemList.SelectedItem;

            this.Items.Restock(selected, Convert.ToInt16(NewStock.Text));

            RefreshList();
            UpdateDetails();
        }
    }
}
