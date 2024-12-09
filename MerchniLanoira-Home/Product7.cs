﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchniLanoira_Home
{
    public partial class Product7 : Form
    {
        String prodBuy = "Cherry On Top Flag";
        double price = 40 * 58;
        public Product7()
        {
            InitializeComponent();
        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product1_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.Show();
        }


        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                double quantity = Convert.ToDouble(QuantityBox.Text);
                double totalPrice = price * quantity;
                Receipt rc = new Receipt(prodBuy, quantity, totalPrice);
                rc.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number for quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
