namespace Milestone_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemList = new System.Windows.Forms.ListBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SearchGroup = new System.Windows.Forms.GroupBox();
            this.SelectedDescription = new System.Windows.Forms.Label();
            this.SelectedPrice = new System.Windows.Forms.Label();
            this.SelectedCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.RestockButton = new System.Windows.Forms.Button();
            this.NewStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedInventory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(12, 12);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(327, 420);
            this.ItemList.TabIndex = 0;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(6, 19);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(212, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(6, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(143, 45);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(416, 402);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(107, 30);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create New";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchGroup
            // 
            this.SearchGroup.Controls.Add(this.SearchBox);
            this.SearchGroup.Controls.Add(this.SearchButton);
            this.SearchGroup.Controls.Add(this.ClearButton);
            this.SearchGroup.Location = new System.Drawing.Point(349, 12);
            this.SearchGroup.Name = "SearchGroup";
            this.SearchGroup.Size = new System.Drawing.Size(224, 82);
            this.SearchGroup.TabIndex = 5;
            this.SearchGroup.TabStop = false;
            this.SearchGroup.Text = "Search";
            // 
            // SelectedDescription
            // 
            this.SelectedDescription.AutoSize = true;
            this.SelectedDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedDescription.Location = new System.Drawing.Point(355, 129);
            this.SelectedDescription.Name = "SelectedDescription";
            this.SelectedDescription.Size = new System.Drawing.Size(51, 20);
            this.SelectedDescription.TabIndex = 6;
            this.SelectedDescription.Text = "label1";
            // 
            // SelectedPrice
            // 
            this.SelectedPrice.AutoSize = true;
            this.SelectedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedPrice.Location = new System.Drawing.Point(355, 173);
            this.SelectedPrice.Name = "SelectedPrice";
            this.SelectedPrice.Size = new System.Drawing.Size(51, 20);
            this.SelectedPrice.TabIndex = 6;
            this.SelectedPrice.Text = "label1";
            // 
            // SelectedCost
            // 
            this.SelectedCost.AutoSize = true;
            this.SelectedCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedCost.Location = new System.Drawing.Point(355, 214);
            this.SelectedCost.Name = "SelectedCost";
            this.SelectedCost.Size = new System.Drawing.Size(51, 20);
            this.SelectedCost.TabIndex = 6;
            this.SelectedCost.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cost";
            // 
            // DeleteItem
            // 
            this.DeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItem.Location = new System.Drawing.Point(428, 358);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(83, 30);
            this.DeleteItem.TabIndex = 4;
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // RestockButton
            // 
            this.RestockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockButton.Location = new System.Drawing.Point(484, 315);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(83, 30);
            this.RestockButton.TabIndex = 4;
            this.RestockButton.Text = "Restock";
            this.RestockButton.UseVisualStyleBackColor = true;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // NewStock
            // 
            this.NewStock.Location = new System.Drawing.Point(355, 320);
            this.NewStock.Name = "NewStock";
            this.NewStock.Size = new System.Drawing.Size(100, 20);
            this.NewStock.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional Stock";
            // 
            // SelectedInventory
            // 
            this.SelectedInventory.AutoSize = true;
            this.SelectedInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedInventory.Location = new System.Drawing.Point(355, 256);
            this.SelectedInventory.Name = "SelectedInventory";
            this.SelectedInventory.Size = new System.Drawing.Size(51, 20);
            this.SelectedInventory.TabIndex = 6;
            this.SelectedInventory.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Inventory";
            // 
            // Form1
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 444);
            this.Controls.Add(this.NewStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedInventory);
            this.Controls.Add(this.SelectedCost);
            this.Controls.Add(this.SelectedPrice);
            this.Controls.Add(this.SelectedDescription);
            this.Controls.Add(this.SearchGroup);
            this.Controls.Add(this.RestockButton);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ItemList);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SearchGroup.ResumeLayout(false);
            this.SearchGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox SearchGroup;
        private System.Windows.Forms.Label SelectedDescription;
        private System.Windows.Forms.Label SelectedPrice;
        private System.Windows.Forms.Label SelectedCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.TextBox NewStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SelectedInventory;
        private System.Windows.Forms.Label label6;
    }
}

