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
    public partial class others : Form
    {
        int price1 = 40 * 58;
        int price2 = 37 * 58;
        public others()
        {
            InitializeComponent();
            Price.Text = "P" + price1;
            label3.Text = "P" + price2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            flag flag = new flag();
            flag.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tote_bag bag = new tote_bag();
            bag.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
