


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
            BackButton = new Button();
            ProductName = new Label();
            Price = new Label();
            YesButton = new Button();
            label2 = new Label();
            Qty = new Label();
            ProductText = new Label();
            QuantityText = new Label();
            PriceText = new Label();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.Location = new Point(32, 17);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(67, 133);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(57, 15);
            ProductName.TabIndex = 1;
            ProductName.Text = "[Product]";
            ProductName.TextAlign = ContentAlignment.MiddleCenter;
            ProductName.Click += ProductName_Click;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(648, 133);
            Price.Name = "Price";
            Price.Size = new Size(41, 15);
            Price.TabIndex = 3;
            Price.Text = "[Price]";
            Price.TextAlign = ContentAlignment.MiddleCenter;
            Price.Click += Price_Click;
            // 
            // YesButton
            // 
            YesButton.Location = new Point(374, 349);
            YesButton.Name = "YesButton";
            YesButton.Size = new Size(75, 23);
            YesButton.TabIndex = 4;
            YesButton.Text = "Buy";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 314);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 5;
            label2.Text = "Do you want to buy this item?";
            // 
            // Qty
            // 
            Qty.AutoSize = true;
            Qty.Location = new Point(473, 133);
            Qty.Name = "Qty";
            Qty.Size = new Size(53, 15);
            Qty.TabIndex = 6;
            Qty.Text = "Quantity";
            Qty.Click += Qty_Click;
            // 
            // ProductText
            // 
            ProductText.AutoSize = true;
            ProductText.Location = new Point(121, 91);
            ProductText.Name = "ProductText";
            ProductText.Size = new Size(49, 15);
            ProductText.TabIndex = 7;
            ProductText.Text = "Product";
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Location = new Point(473, 91);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(53, 15);
            QuantityText.TabIndex = 8;
            QuantityText.Text = "Quantity";
            QuantityText.Click += label1_Click_1;
            // 
            // PriceText
            // 
            PriceText.AutoSize = true;
            PriceText.Location = new Point(648, 91);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(61, 15);
            PriceText.TabIndex = 9;
            PriceText.Text = "Total Price";
            PriceText.Click += label1_Click_2;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PriceText);
            Controls.Add(QuantityText);
            Controls.Add(ProductText);
            Controls.Add(Qty);
            Controls.Add(label2);
            Controls.Add(YesButton);
            Controls.Add(Price);
            Controls.Add(ProductName);
            Controls.Add(BackButton);
            Name = "Receipt";
            Text = "Receipt";
            Load += Receipt_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label ProductName;
        private Label Price;
        private Button YesButton;
        private Label label2;
        private Label Qty;
        private Label ProductText;
        private Label QuantityText;
        private Label PriceText;
    }
}