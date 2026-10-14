using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        // Defines the three drink sizes the customer can choose.
        enum DrinkSize
        {
            Small,
            Medium,
            Large
        }

        // Groups the information for one entry in the order.
        struct OrderItem
        {
            public string DrinkName;
            public DrinkSize Size;
            public int Quantity;
            public decimal UnitPrice;
        }

        // Fixed menu choices are stored in an array.
        private string[] drinkNames = { "Coffee", "Latte", "Tea" };

        // Each drink name is a key connected to its small-size price.
        private Dictionary<string, decimal> drinkPrices =
            new Dictionary<string, decimal>()
            {
                { "Coffee", 3.00m },
                { "Latte", 4.00m },
                { "Tea", 2.00m }
            };

        // This list grows and shrinks as the customer changes the order.
        private List<OrderItem> orderItems = new List<OrderItem>();
        private decimal orderTotal = 0.00m;

        public Form1()
        {
            InitializeComponent();

            // Keep the display in the same order as the stored data.
            drinkListBox.Sorted = false;
            orderListBox.Sorted = false;
            drinkListBox.SelectionMode = SelectionMode.One;
            orderListBox.SelectionMode = SelectionMode.One;
            orderListBox.HorizontalScrollbar = true;

            // Replace any menu items entered.
            drinkListBox.Items.Clear();
            foreach (string drink in drinkNames)
            {
                drinkListBox.Items.Add(drink);
            }

            smallRadioButton.Checked = true;
            quantityTextBox.Text = "1";
            RefreshOrderDisplay();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Make sure a drink is selected and the quantity is a positive whole number.
            if (drinkListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a drink.");
                return;
            }

            //Check that the quantity is a positive whole number greater than zero.
            int quantity;
            if (!int.TryParse(quantityTextBox.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a positive whole-number quantity.");
                quantityTextBox.Focus();
                return;
            }

            DrinkSize selectedSize;
            decimal sizeCharge;

            //Get the selected size and its associated charge.
            if (smallRadioButton.Checked)
            {
                selectedSize = DrinkSize.Small;
                sizeCharge = 0.00m;
            }
            else if (mediumRadioButton.Checked)
            {
                selectedSize = DrinkSize.Medium;
                sizeCharge = 0.50m;
            }
            else if (largeRadioButton.Checked)
            {
                selectedSize = DrinkSize.Large;
                sizeCharge = 1.00m;
            }
            else
            {
                MessageBox.Show("Please select a drink size.");
                return;
            }
            

            //Get the selected drink name from the array.
            string drinkName = drinkNames[drinkListBox.SelectedIndex];
            //Look up the base price in the dictionary and add the size charge to get the unit price.
            decimal unitPrice = drinkPrices[drinkName] + sizeCharge;

            //Store this order entry's information in a struct.
            OrderItem item = new OrderItem();
            item.DrinkName = drinkName;
            item.Size = selectedSize;
            item.Quantity = quantity;
            item.UnitPrice = unitPrice;

            //Add the struct to the list and refresh the display.
            orderItems.Add(item);
            RefreshOrderDisplay();
        }

        // Rebuilds the display and calculates the total from the stored order.
        private void RefreshOrderDisplay()
        {
            orderListBox.Items.Clear();
            orderTotal = 0.00m;

            foreach (OrderItem item in orderItems)
            {
                decimal lineTotal = item.UnitPrice * item.Quantity;
                orderTotal += lineTotal;

                orderListBox.Items.Add(
                    item.Quantity + " " + item.Size + " " + item.DrinkName +
                    " - " + lineTotal.ToString("C2"));
            }

            totalLabel.Text = "Total: " + orderTotal.ToString("C2");
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = orderListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an order entry to remove.");
                return;
            }

            // The ListBox and List have matching indexes.
            orderItems.RemoveAt(selectedIndex);
            RefreshOrderDisplay();
        }

        // Clears the order and resets the customer's choices.
        private void ClearOrder()
        {
            //Remove all items from the order and refresh the display.
            orderItems.Clear();
            RefreshOrderDisplay();

            //Deselect the drink and reset the size and quantity to their defaults.
            drinkListBox.SelectedIndex = -1;
            smallRadioButton.Checked = true;
            quantityTextBox.Text = "1";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the order when the clear button is clicked.
            ClearOrder();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            //Make sure the order is not empty before checking out.
            if (orderItems.Count == 0)
            {
                MessageBox.Show("Please add a drink before checking out.");
                return;
            }

            //Show the total formatted as currency and thank the customer for their order.
            MessageBox.Show(
                "Your total is " + orderTotal.ToString("C2") +
                ". Thank you for your order!",
                "Checkout");

            //Reset the order for the next customer.
            ClearOrder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void drinkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void radioButtons_Enter(object sender, EventArgs e)
        {
        }

        private void smallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void largeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void orderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
