namespace MerchniLanoira_Home
{
    partial class Product2
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
            ProdDescription1 = new Label();
            Price = new Label();
            ColorText = new Label();
            QuantityText = new Label();
            QuantityBox = new TextBox();
            BuyButton = new Button();
            BackButton = new Button();
            Picture = new Label();
            ColorCombo = new ComboBox();
            SuspendLayout();
            // 
            // ProdDescription1
            // 
            ProdDescription1.AutoSize = true;
            ProdDescription1.Location = new Point(843, 130);
            ProdDescription1.Name = "ProdDescription1";
            ProdDescription1.Size = new Size(120, 15);
            ProdDescription1.TabIndex = 0;
            ProdDescription1.Text = "[Product Description]";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(843, 164);
            Price.Name = "Price";
            Price.Size = new Size(41, 15);
            Price.TabIndex = 1;
            Price.Text = "[Price]";
            Price.Click += Price_Click;
            // 
            // ColorText
            // 
            ColorText.AutoSize = true;
            ColorText.Location = new Point(843, 206);
            ColorText.Name = "ColorText";
            ColorText.Size = new Size(36, 15);
            ColorText.TabIndex = 2;
            ColorText.Text = "Color";
            // 
            // QuantityText
            // 
            QuantityText.AutoSize = true;
            QuantityText.Location = new Point(843, 307);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(53, 15);
            QuantityText.TabIndex = 4;
            QuantityText.Text = "Quantity";
            // 
            // QuantityBox
            // 
            QuantityBox.Location = new Point(843, 343);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(100, 23);
            QuantityBox.TabIndex = 5;
            QuantityBox.TextChanged += QuantityBox_TextChanged;
            // 
            // BuyButton
            // 
            BuyButton.Location = new Point(843, 406);
            BuyButton.Name = "BuyButton";
            BuyButton.Size = new Size(75, 23);
            BuyButton.TabIndex = 6;
            BuyButton.Text = "Buy";
            BuyButton.UseVisualStyleBackColor = true;
            BuyButton.Click += BuyButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(28, 23);
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
            Picture.Location = new Point(230, 212);
            Picture.Name = "Picture";
            Picture.Size = new Size(52, 15);
            Picture.TabIndex = 8;
            Picture.Text = "[Picture]";
            // 
            // ColorCombo
            // 
            ColorCombo.FormattingEnabled = true;
            ColorCombo.Items.AddRange(new object[] { "Black", "Light Pink", "White" });
            ColorCombo.Location = new Point(843, 249);
            ColorCombo.Name = "ColorCombo";
            ColorCombo.Size = new Size(133, 23);
            ColorCombo.TabIndex = 9;
            ColorCombo.SelectedIndexChanged += ColorCombo_SelectedIndexChanged;
            // 
            // Product2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 636);
            Controls.Add(ColorCombo);
            Controls.Add(Picture);
            Controls.Add(BackButton);
            Controls.Add(BuyButton);
            Controls.Add(QuantityBox);
            Controls.Add(QuantityText);
            Controls.Add(ColorText);
            Controls.Add(Price);
            Controls.Add(ProdDescription1);
            Name = "Product2";
            Text = "Product2";
            Load += Product1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProdDescription1;
        private Label Price;
        private Label ColorText;
        private Label QuantityText;
        private TextBox QuantityBox;
        private Button BuyButton;
        private Button BackButton;
        private Label Picture;
        private ComboBox ColorCombo;
    }
}