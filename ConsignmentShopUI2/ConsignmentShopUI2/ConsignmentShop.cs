using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI2
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;



        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            //Store Items
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            //Shopping Cart
            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            //Vendors
            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            /* Vendor demoVendor = new Vendor;
             demoVendor.FirstName = "Bill";
             demoVendor.LastName = "Smith";
             demoVendor.Commision = .5;

             store.Vendors.Add(demoVendor);

             Vendor demoVendor = new Vendor;
             demoVendor.FirstName = "Sue";
             demoVendor.LastName = "Jones";
             demoVendor.Commision = .5;

             store.Vendors.Add(demoVendor);
             store.Vendors = new List<Vendor>();*/

            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter Book 1",
                Description = "A book about a boy",
                Price = 5.20M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 1.50M,
                Owner = store.Vendors[0]
            });

            store.Name = "Seconds Are Better";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ItemslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected form the items list
            //Copy that item to the shopping cart
            //Do we remove the item from the items list? -No

            Item SelectedItem = (Item)itemsListBox.SelectedItem;

            shoppingCartData.Add(SelectedItem);

            cartBinding.ResetBindings(false);
        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            // Mark each item in cart as sold
            // Clear the cart

            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commision * item.Price;
                storeProfit += ( 1 - (decimal)item.Owner.Commision) * item.Price;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValuelabel.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
