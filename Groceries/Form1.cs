using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groceries
{
    public partial class Form1 : Form
    {
        private List<Item> myCart = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }
        //continue on 1:33:54mnts

        //declare vegetable names units using 2-dimentional array with initializer list
        private string [,
            ] vegetables = { { "Avocades", "each"},{ "Green Beans", "per pound"},
            { "Mushrooms", "per 8 oz"},{ "Weet Onions", "per pound"} };
        private decimal[] vegetablePrices = { 1.25m, 1.49m, 1.69m, 0.99m };
        private void Form1_Load(object sender, EventArgs e)
        {
            int index;

            //declare fruit array (3 is upper index, 4 is length)
            string [] fruits = new string [4];

            //populate fruit array
            fruits[0] = "Bananas";
            fruits[1] = "Gala Apples";
            fruits[2] = "Pears";
            fruits[3] = "Red Grapes";

            string message = "This week we offer: ";
        
        //build message from array
        for(index = 0; index < fruits.Length - 1; index++)
            {
                message += fruits[index] + ", ";
            }
            message += "and " + fruits[index];

        MessageBox.Show(message, "Fruit Selections", MessageBoxButtons.OK);

            foreach(string fruit in fruits)
            {
                lstFruit.Items.Add(fruit);
            }

            for (index = 0; index <= vegetables.GetUpperBound(0); index++)
            {
                lstVegetables.Items.Add(vegetables[index, 0]);
            }

            return;
        }

        //Purchase
        #region Hidden Declaration code
        // declare fruit prices using initializer list
        private decimal[] prices = { 0.69m, 1.29m, 2.99m, 1.99m };
        private string[] units = { "per pound", "per pound", "each", "per pound" };
        #endregion
        private void btnPurchase_Click(object sender, EventArgs e)
        {


            if (lstFruit.SelectedIndex == -1 && lstVegetables.SelectedIndex == -1)
            {
                lblMessage.Text = "Please select a fruit or vegetable";
            }
            else
            {
                string message = "You are purchasing: ";
                if (lstFruit.SelectedIndex != -1)
                {

                    Item myItem = new Item();

                    myItem.Description = lstFruit.SelectedItem.ToString();
                    myItem.Price = prices[lstFruit.SelectedIndex];
                    myItem.Units = units[lstFruit.SelectedIndex] ;

                    myCart.Add(myItem);
                    lstCart.Items.Add(myItem.ToString());

                    message += Environment.NewLine + myItem.ToString();

                    //message += Environment.NewLine + lstFruit.SelectedItems.ToString() + " at " + 
                    //    prices[lstFruit.SelectedIndex].ToString("C") + " " + units[lstFruit.SelectedIndex];
                   
                }
                if (lstVegetables.SelectedIndex != -1)
                {

                    Item myItem = new Item(lstVegetables.SelectedItem.ToString(),vegetablePrices[lstVegetables.SelectedIndex],
                       vegetables[lstVegetables.SelectedIndex, 1]);

                    myItem.Description = lstVegetables.SelectedItem.ToString();
                    myItem.Price = vegetablePrices[lstVegetables.SelectedIndex];
                    myItem.Units = vegetables[lstVegetables.SelectedIndex, 1];

                    myCart.Add(myItem);
                    lstCart.Items.Add(myItem.ToString());

                    message += Environment.NewLine + myItem.ToString();  
                }
                lblMessage.Text = message;
            }
        }

        //Exit statement
        private void btnExit_Click(object sender, EventArgs e)
        {
            #region MyRegion
            string message = string.Empty;

            foreach(Item item in myCart)
            {
                message += Environment.NewLine + item.ToString();
            }
            MessageBox.Show(message, "My Cart");
            #endregion

            Close();
            
        }
    }
}
