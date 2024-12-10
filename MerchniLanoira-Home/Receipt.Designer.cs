


namespace MerchniLanoira_Home
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            BackButton = new Button();
            YesButton = new Button();
            label3 = new Label();
            Qty = new Label();
            ProductText = new Label();
            Price = new Label();
            QuantityText = new Label();
            ProductName = new Label();
            PriceText = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // YesButton
            // 
            YesButton.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YesButton.Location = new Point(235, 281);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(95, 26);
            YesButton.TabIndex = 4;
            YesButton.Text = "BUY";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 33);
            label3.Name = "label3";
            label3.Size = new Size(229, 30);
            label3.TabIndex = 11;
            label3.Text = "Payment Confirmation";
            label3.Click += label3_Click;
            // 
            // Qty
            // 
            Qty.AutoSize = true;
            Qty.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Qty.Location = new Point(102, 170);
            Qty.Name = "Qty";
            Qty.Size = new Size(73, 17);
            Qty.TabIndex = 6;
            Qty.Text = "[Quantity]";
            Qty.Click += Qty_Click;
            // 
            // ProductText
            // 
            ProductText.AutoSize = true;
            ProductText.Font = new Font("Yu Gothic", 9.75F);
            ProductText.ForeColor = SystemColors.ControlDarkDark;
            ProductText.Location = new Point(39, 140);
            ProductText.Name = "ProductText";
            ProductText.Size = new Size(57, 17);
            ProductText.TabIndex = 7;
            ProductText.Text = "Product";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price.ForeColor = Color.DarkCyan;
            Price.Location = new Point(235, 226);
            Price.Name = "Price";
            Price.Size = new Size(95, 37);
            Price.TabIndex = 3;
            Price.Text = "[Price]";
            Price.TextAlign = ContentAlignment.MiddleCenter;
            Price.Click += Price_Click;
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Font = new Font("Yu Gothic", 9.75F);
            QuantityText.ForeColor = SystemColors.ControlDarkDark;
            QuantityText.Location = new Point(39, 170);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(60, 17);
            QuantityText.TabIndex = 8;
            QuantityText.Text = "Quantity";
            QuantityText.Click += label1_Click_1;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(102, 140);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(110, 17);
            ProductName.TabIndex = 1;
            ProductName.Text = "[Product Name]";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            ProductName.Click += ProductName_Click;
            // 
            // PriceText
            // 
            PriceText.AutoSize = true;
            PriceText.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PriceText.ForeColor = SystemColors.ControlDarkDark;
            PriceText.Location = new Point(39, 226);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(80, 20);
            PriceText.TabIndex = 9;
            PriceText.Text = "Total Price";
            PriceText.Click += label1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(40, 74);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 10;
            label1.Text = "Payment Details";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(PriceText);
            panel2.Controls.Add(YesButton);
            panel2.Controls.Add(ProductName);
            panel2.Controls.Add(QuantityText);
            panel2.Controls.Add(Price);
            panel2.Controls.Add(ProductText);
            panel2.Controls.Add(Qty);
            panel2.Location = new Point(244, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 355);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(164, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 308);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(797, 450);
            Controls.Add(panel2);
            Controls.Add(BackButton);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }





        #endregion

        private Button BackButton;
        private Button YesButton;
        private Label label3;
        private Label Qty;
        private Label ProductText;
        private Label Price;
        private Label QuantityText;
        private Label ProductName;
        private Label PriceText;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}