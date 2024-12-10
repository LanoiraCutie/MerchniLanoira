using System;
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
    public partial class Product1 : Form
    {
        String prodtoBuy = "Cherry On Top Mug [Red]";
        int price = 25 * 58;
        public Product1()
        {
            InitializeComponent();
            Price.Text = "P" + price;
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
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(QuantityBox.Text);
                int totalprice = quantity * price;
                Receipt receipt = new Receipt(prodtoBuy, quantity, totalprice);
                receipt.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter number in Quantity. No spaces!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
