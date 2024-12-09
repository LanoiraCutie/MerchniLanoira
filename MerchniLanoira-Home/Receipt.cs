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
    public partial class Receipt : Form
    {
        String prod = "";
        public Receipt(String prodtoBuy, double quantity, double totalPrice)
        {
            InitializeComponent();
            ProductName.Text = prodtoBuy;
            prod = prodtoBuy;
            Qty.Text = quantity.ToString();
            Price.Text = "P" + totalPrice.ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void ProductName_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void Qty_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bought successfully. Item will be magically coming to you within 24 hours.", prod + " bought!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
