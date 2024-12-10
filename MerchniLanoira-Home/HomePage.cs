namespace MerchniLanoira_Home
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void GProductText1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }


        private void GProductText3_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeText_Click(object sender, EventArgs e)
        {

        }

        private void ProductText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            shopnow shopnow = new shopnow();
            shopnow.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            shirts shirts = new shirts();
            shirts.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mugs mugs = new mugs();
            mugs.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            hats hats = new hats();
            hats.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            others others = new others();
            others.Show();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
