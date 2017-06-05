namespace ConsignmentShopUI2
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.shoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.venderListBoxLabel = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValuelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(268, 23);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(185, 37);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Book Store";
            // 
            // itemsListBox
            // 
            this.itemsListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(12, 71);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(254, 144);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemslistBox_SelectedIndexChanged);
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(12, 48);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(287, 107);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(127, 49);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add To Cart ->";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // shoppingCartListBoxLabel
            // 
            this.shoppingCartListBoxLabel.AutoSize = true;
            this.shoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListBoxLabel.Location = new System.Drawing.Point(437, 71);
            this.shoppingCartListBoxLabel.Name = "shoppingCartListBoxLabel";
            this.shoppingCartListBoxLabel.Size = new System.Drawing.Size(124, 20);
            this.shoppingCartListBoxLabel.TabIndex = 5;
            this.shoppingCartListBoxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListBox
            // 
            this.shoppingCartListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.shoppingCartListBox.FormattingEnabled = true;
            this.shoppingCartListBox.ItemHeight = 20;
            this.shoppingCartListBox.Location = new System.Drawing.Point(441, 94);
            this.shoppingCartListBox.Name = "shoppingCartListBox";
            this.shoppingCartListBox.Size = new System.Drawing.Size(254, 144);
            this.shoppingCartListBox.TabIndex = 4;
            this.shoppingCartListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(568, 244);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(127, 49);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBoxLabel.Location = new System.Drawing.Point(12, 253);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(0, 20);
            this.vendorListBoxLabel.TabIndex = 8;
            // 
            // vendorListBox
            // 
            this.vendorListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(12, 276);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(254, 144);
            this.vendorListBox.TabIndex = 7;
            // 
            // venderListBoxLabel
            // 
            this.venderListBoxLabel.AutoSize = true;
            this.venderListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venderListBoxLabel.Location = new System.Drawing.Point(12, 258);
            this.venderListBoxLabel.Name = "venderListBoxLabel";
            this.venderListBoxLabel.Size = new System.Drawing.Size(76, 20);
            this.venderListBoxLabel.TabIndex = 9;
            this.venderListBoxLabel.Text = "Vendors";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(437, 362);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(106, 20);
            this.storeProfitLabel.TabIndex = 10;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValuelabel
            // 
            this.storeProfitValuelabel.AutoSize = true;
            this.storeProfitValuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValuelabel.Location = new System.Drawing.Point(564, 362);
            this.storeProfitValuelabel.Name = "storeProfitValuelabel";
            this.storeProfitValuelabel.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValuelabel.TabIndex = 11;
            this.storeProfitValuelabel.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 464);
            this.Controls.Add(this.storeProfitValuelabel);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.venderListBoxLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListBoxLabel);
            this.Controls.Add(this.shoppingCartListBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Eric\'s Book Store App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label shoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox shoppingCartListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Label vendorListBoxLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label venderListBoxLabel;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValuelabel;
    }
}

