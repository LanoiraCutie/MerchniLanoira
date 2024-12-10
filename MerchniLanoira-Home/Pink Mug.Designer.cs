namespace MerchniLanoira_Home
{
    partial class form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Picture = new Label();
            BackButton = new Button();
            BuyButton = new Button();
            QuantityBox = new TextBox();
            QuantityText = new Label();
            Price = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(368, 105);
            label1.Name = "label1";
            label1.Size = new Size(321, 37);
            label1.TabIndex = 20;
            label1.Text = "Cherry On Top Mug [Pink]";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(27, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Picture
            // 
            Picture.AutoSize = true;
            Picture.Location = new Point(202, 233);
            Picture.Name = "Picture";
            Picture.Size = new Size(0, 15);
            Picture.TabIndex = 18;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 17;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuyButton.Location = new Point(368, 329);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(175, 53);
            BuyButton.TabIndex = 16;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(379, 263);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(66, 23);
            QuantityBox.TabIndex = 15;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityText.Location = new Point(379, 228);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(65, 20);
            QuantityText.TabIndex = 14;
            QuantityText.Text = "Quantity";
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
            Price.TabIndex = 13;
            Price.Text = "[Price]";
            // 
            // form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Picture);
            Controls.Add(BackButton);
            Controls.Add(BuyButton);
            Controls.Add(QuantityBox);
            Controls.Add(QuantityText);
            Controls.Add(Price);
            Name = "form2";
            Text = "Cherry On Top Mug [Pink]";
            Load += form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label Picture;
        private Button BackButton;
        private Button BuyButton;
        private TextBox QuantityBox;
        private Label QuantityText;
        private Label Price;
    }
}