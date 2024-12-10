using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchniLanoira_Home
{
    public partial class form2 : Form
    {
        int price = 25 * 58;
        string prodtoBuy = "Cherry On Top Mug [Pink]";
        public form2()
        {
            InitializeComponent();
            Price.Text = "P" + price;
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
