namespace MerchniLanoira_Home
{
    partial class light_pink_crewneck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(light_pink_crewneck));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Picture = new Label();
            BackButton = new Button();
            BuyButton = new Button();
            QuantityBox = new TextBox();
            QuantityText = new Label();
            Price = new Label();
            ProdDescription1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 68);
            label1.Name = "label1";
            label1.Size = new Size(351, 74);
            label1.TabIndex = 38;
            label1.Text = "Cherry Crewneck Sweatshirt \r\n[Light Pink]";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(42, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // Picture
            // 
            Picture.AutoSize = true;
            Picture.Location = new Point(202, 233);
            Picture.Name = "Picture";
            Picture.Size = new Size(0, 15);
            Picture.TabIndex = 36;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 35;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // BuyButton
            // 
            BuyButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BuyButton.Location = new Point(371, 329);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(175, 53);
            BuyButton.TabIndex = 34;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(371, 276);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(66, 23);
            QuantityBox.TabIndex = 33;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuantityText.Location = new Point(371, 253);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(65, 20);
            QuantityText.TabIndex = 32;
            QuantityText.Text = "Quantity";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.ForeColor = SystemColors.ControlDarkDark;
            Price.Location = new Point(371, 210);
            Price.Name = "Price";
            Price.Size = new Size(66, 25);
            Price.TabIndex = 31;
            Price.Text = "[Price]";
            // 
            // ProdDescription1
            // 
            ProdDescription1.AutoSize = true;
            ProdDescription1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProdDescription1.Location = new Point(371, 163);
            ProdDescription1.Name = "ProdDescription1";
            ProdDescription1.Size = new Size(150, 20);
            ProdDescription1.TabIndex = 30;
            ProdDescription1.Text = "[Product Description]";
            // 
            // light_pink_crewneck
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
            Controls.Add(ProdDescription1);
            Name = "light_pink_crewneck";
            Text = "light_pink_crewneck";
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
        private Label ProdDescription1;
    }
}