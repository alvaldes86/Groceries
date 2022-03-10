﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }


        //continue mnt 44
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

            return;
        }

        #region Hidden Declaration code
        // declare fruit prices using initializer list
        private decimal[] prices = { 0.69m, 1.29m, 2.99m, 1.99m };
        private string[] units = { "per pound", "pewr pound", "each", "per pound" };
        #endregion
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if(lstFruit.SelectedIndex == -1)
            {
                lblMessage.Text = "Please select a fruit";
            }
            else
            {
                string message = "You are purchasing: ";

                message += Environment.NewLine + lstFruit.SelectedItems.ToString() + " at " + 
                    prices[lstFruit.SelectedIndex].ToString("C") + " " + units[lstFruit.SelectedIndex];

                lblMessage.Text = message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            //this is a test
        }
    }
}
