namespace MerchniLanoira_Home
{
    partial class Product1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product1));
            Price = new Label();
            QuantityText = new Label();
            QuantityBox = new TextBox();
            BuyButton = new Button();
            BackButton = new Button();
            Picture = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.ForeColor = SystemColors.ControlDarkDark;
            Price.Location = new Point(379, 172);
            Price.Name = "Price";
            Price.Size = new Size(66, 25);
            Price.TabIndex = 1;
            Price.Text = "[Price]";
            Price.Click += Price_Click;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityText.Location = new Point(379, 228);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(65, 20);
            QuantityText.TabIndex = 4;
            QuantityText.Text = "Quantity";
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(379, 263);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(66, 23);
            QuantityBox.TabIndex = 5;
            QuantityBox.TextChanged += QuantityBox_TextChanged;
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuyButton.Location = new Point(368, 329);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(175, 53);
            BuyButton.TabIndex = 6;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // Picture
            // 
            Picture.AutoSize = true;
            Picture.Location = new Point(202, 233);
            Picture.Name = "Picture";
            Picture.Size = new Size(0, 15);
            Picture.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 112);
            label1.Name = "label1";
            label1.Size = new Size(317, 37);
            label1.TabIndex = 11;
            label1.Text = "Cherry On Top Mug [Red]";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Product1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 459);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(Picture);
            Controls.Add(BackButton);
            Controls.Add(BuyButton);
            Controls.Add(QuantityBox);
            Controls.Add(QuantityText);
            Controls.Add(Price);
            DoubleBuffered = true;
            Name = "Product1";
            Text = "Cherry On Top Mug [Red]";
            Load += Product1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Price;
        private Label QuantityText;
        private TextBox QuantityBox;
        private Button BuyButton;
        private Button BackButton;
        private Label Picture;
        private Label label1;
        private PictureBox pictureBox1;
    }
}