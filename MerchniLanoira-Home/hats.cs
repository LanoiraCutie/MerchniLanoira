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
    public partial class hats : Form
    {
        int price = 36 * 58;
        public hats()
        {
            InitializeComponent();
            Price.Text = "P" + price;
            label3.Text = "P" + price;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            black_hat black_Hat = new black_hat();
            black_Hat.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            white_hat white_Hat = new white_hat();
            white_Hat.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
