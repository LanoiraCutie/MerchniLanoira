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
    public partial class shirts : Form
    {
        int price = 65 * 58;
        public shirts()
        {
            InitializeComponent();
            Price.Text = "P" + price;
            label3.Text = "P" + price;
        }

        private void shirts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 black_crewneck = new Form1();
            black_crewneck.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            light_pink_crewneck light_Pink_Crewneck = new light_pink_crewneck();
            light_Pink_Crewneck.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }
    }
}
