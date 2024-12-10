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
    public partial class tote_bag : Form
    {
        int price = 37 * 58;
        string prodtoBuy = "Cherry On Top Eco Tote Bag";
        public tote_bag()
        {
            InitializeComponent();
            Price.Text = "P" + price;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tote_bag_Load(object sender, EventArgs e)
        {

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
